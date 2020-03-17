using System;
using System.Collections.Generic;

namespace SecurityProject.Models.Models
{
    public partial class UserRegistration
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Role { get; set; }

        
    }
}
