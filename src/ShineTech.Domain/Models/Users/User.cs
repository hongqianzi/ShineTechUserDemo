using ShineTech.Domain.Models.Shared;
using ShineTech.Domain.SeedWork;
using System;

namespace ShineTech.Domain.Models.Users
{
    public class User : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public Email Email { get; private set; }
        public string DriverLicense { get; private set; }
        public DateTime DOB { get; private set; }
        public Address Address { get; private set; }
        public Phone Phone { get; private set; }

        protected User()
        {
        }
        public User(string name, string driverLicense, DateTime DOB, Email email, Address address, Phone phone)
        {
            if (string.IsNullOrEmpty(name))
                throw CustomException.NullArgument(nameof(name));

            if (string.IsNullOrEmpty(driverLicense))
                throw CustomException.NullArgument(nameof(driverLicense));

            Name = name;
            DriverLicense = driverLicense;
            this.DOB = DOB;
            Address = address ?? throw CustomException.NullArgument(nameof(address));
            Phone = phone ?? throw CustomException.NullArgument(nameof(phone));
            Email = email ?? throw CustomException.NullArgument(nameof(email));
        }

        public void UpdateEmail(Email email)
        {
            Email = email ?? throw CustomException.NullArgument(nameof(email));
        }
        public void UpdatePhone(Phone phone)
        {
            Phone = phone ?? throw CustomException.NullArgument(nameof(phone));
        }
        public void UpdateAddress(Address address)
        {
            Address = address ?? throw CustomException.NullArgument(nameof(address));
        }

    }
}
