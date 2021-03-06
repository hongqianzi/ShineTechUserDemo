﻿using ShineTech.Domain.SeedWork;

namespace ShineTech.Domain.Models.Shared
{
    public class Phone
    {
        public string Value { get; private set; }

        public Phone(string value)
        {
            if (!int.TryParse(value, out int x) || value.Length < 6)
                throw CustomException.InvalidArgument(nameof(Phone));

            Value = value;
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
