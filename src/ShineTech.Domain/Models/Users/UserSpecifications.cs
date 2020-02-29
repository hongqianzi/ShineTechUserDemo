using ShineTech.Domain.SeedWork;
using System;

namespace ShineTech.Domain.Models.Users
{
    public class UsersByFiltersSpecification : SpecificationBase<User>
    {
        public UsersByFiltersSpecification(string name, string driverlicense)
            : base(t => t.Name.Contains(name) && t.DriverLicense.Contains(driverlicense))
        {

        }
    }

    public class UserByIdSpecification : SpecificationBase<User>
    {
        public UserByIdSpecification(Guid id)
            : base(t => t.Id == id)
        {
        }
    }
}
