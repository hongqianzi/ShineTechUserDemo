using AutoMapper;
using MediatR;
using ShineTech.Domain.Models.Shared;
using ShineTech.Domain.Models.Users;
using ShineTech.Domain.SeedWork;
using ShineTech.Web.Users.Commands;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace ShineTech.Web.Users
{
    public class UserCommandHandler
        : IRequestHandler<CreateUserCommand, UserDTO>
        , IRequestHandler<UserByIdQuery, UserDTO>
        , IRequestHandler<UserByFiltersQuery, IEnumerable<UserDTO>>

    {
        private readonly IUnitOfWork _uow;
        private readonly IUserRepository _customerRepository;
        private readonly IMapper _mapper;

        public UserCommandHandler(IUserRepository customerRepository, IUnitOfWork uow, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _uow = uow;
            _mapper = mapper;
        }


        public async Task<UserDTO> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            Address address = new Address(request.Street, request.City, request.ZipCode);
            Phone phone = new Phone(request.Phone);
            Email email = Email.FromString(request.Email);
            User customer = new User(request.Name, request.DriverLicense, request.DOB, email, address, phone);
            _customerRepository.Add(customer);
            await _uow.CommitAsync(cancellationToken);
            return _mapper.Map<UserDTO>(customer);
        }

        public async Task<UserDTO> Handle(UserByIdQuery request, CancellationToken cancellationToken)
        {
            User user = await _customerRepository.FindOneAsync(new UserByIdSpecification(request.Id));
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<IEnumerable<UserDTO>> Handle(UserByFiltersQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<User> customers = await _customerRepository.FindAllAsync(new UsersByFiltersSpecification(request.Name ?? string.Empty, request.DriverLicense ?? string.Empty));
            return _mapper.Map<IEnumerable<UserDTO>>(customers);
        }
    }
}
