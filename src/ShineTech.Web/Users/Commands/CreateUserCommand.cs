using MediatR;
using System;

namespace ShineTech.Web.Users.Commands
{
    public class CreateUserCommand : IRequest<UserDTO>
    {
        public string Name { get; set; }
        public string DriverLicense { get; set; }
        public DateTime DOB { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public CreateUserCommand(string name, string driverLicense, DateTime DOB, string street, string city, string zipCode, string email, string phone)
        {
            Name = name;
            DriverLicense = driverLicense;
            this.DOB = DOB;
            Street = street;
            City = city;
            ZipCode = zipCode;
            Phone = phone;
            Email = email;
        }
    }

}
