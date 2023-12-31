﻿

using Microsoft.AspNetCore.Identity;

namespace CarHub_Models
{
    public class ApplicationUserDTO : IdentityUser
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string PassWord { get; set; }
        public string Role { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
	}
}
