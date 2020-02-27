using System;
using System.Collections.Generic;
using System.Text;

namespace UserShineTech.Models
{
    public class User
    {
        public string Name { get; set; }
        public string PassWord { get; set; }
        public string Id { get; set; }
        public bool Sex { get; set; }

        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
    }
}
