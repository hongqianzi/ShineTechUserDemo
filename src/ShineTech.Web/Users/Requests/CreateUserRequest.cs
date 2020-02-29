﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ShineTech.Web.Users.Requests
{
    public class CreateUserRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string DriverLicense { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
