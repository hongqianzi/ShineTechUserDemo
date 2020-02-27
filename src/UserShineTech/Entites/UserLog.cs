using System;

namespace UserShineTech.Models
{
    public class UserLog
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime LogTime { get; set; }
        /// <summary>
        /// true login
        /// false logout
        /// </summary>
        public bool LogType { get; set; }

    }
}
