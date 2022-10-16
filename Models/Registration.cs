using System;
using System.Collections.Generic;

namespace NYKAA_ANGULAR_API.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Useremail { get; set; }
        public string? Password { get; set; }
        public string? Mobile { get; set; }
    }
}
