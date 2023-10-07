using Microsoft.AspNetCore.Identity;

namespace CarHub_Models
{
    public class ApplicationRoleDTO : IdentityRole
    {
        public bool IsChecked { get; set; }
    }
}
