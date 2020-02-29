using MediatR;
using System;

namespace ShineTech.Web.Users.Commands
{
    public class UserByIdQuery : IRequest<UserDTO>
    {
        public Guid Id { get; set; }
        public UserByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
