using ShineTech.Domain.SeedWork;

namespace ShineTech.Domain.Models.Shared
{
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string ZipCode { get; private set; }

        public Address(string street, string city, string zipCode)
        {
            if (string.IsNullOrEmpty(street))
                throw CustomException.NullArgument(nameof(Street));

            if (string.IsNullOrEmpty(city))
                throw CustomException.NullArgument(nameof(City));

            if (string.IsNullOrEmpty(zipCode))
                throw CustomException.NullArgument(nameof(ZipCode));

            Street = street;
            City = city;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{Street}, {City} - {ZipCode}";
        }
    }
}
