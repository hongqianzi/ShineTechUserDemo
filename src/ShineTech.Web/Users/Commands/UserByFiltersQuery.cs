using MediatR;
using System.Collections.Generic;
namespace ShineTech.Web.Users.Commands
{
    public class UserByFiltersQuery : IRequest<IEnumerable<UserDTO>>
    {
        public string Name { get; set; }
        public string DriverLicense { get; set; }

        public UserByFiltersQuery(string name, string driverLicense)
        {
            Name = name ?? string.Empty;
            DriverLicense = driverLicense ?? string.Empty;
        }
    }
}
