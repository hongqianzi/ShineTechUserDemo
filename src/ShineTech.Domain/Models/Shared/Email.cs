﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShineTech.Domain.Models.Shared
{
    public class Email
    {
        public string Value { get; private set; }

        public Email(string value)
        {
            // *** email validation ***

            Value = value;
        }

        public static Email FromString(string value)
        {
            return new Email(value);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
