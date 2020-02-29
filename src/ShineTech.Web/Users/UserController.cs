using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShineTech.Domain.SeedWork;
using ShineTech.Web.Users.Commands;
using ShineTech.Web.Users.Requests;

namespace ShineTech.Web.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromRoute]Guid id)
        {
            UserDTO customer = await _mediator.Send(new UserByIdQuery(id));
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        [HttpGet(Name = "CustomerByFilters")]
        [ProducesResponseType(typeof(IEnumerable<UserDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get([FromQuery] string name, [FromQuery] string driverlicense)
        {
            IEnumerable<UserDTO> result = await _mediator.Send(new UserByFiltersQuery(name, driverlicense));
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(UserDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] CreateUserRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var command = new CreateUserCommand(request.Name, request.DriverLicense, request.DOB, request.Street, request.City, request.ZipCode, request.Email, request.Phone);
                UserDTO customer = await _mediator.Send(command);
                return Created(string.Empty, customer);
            }
            catch (CustomException ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
