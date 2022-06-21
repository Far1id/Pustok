using Microsoft.AspNetCore.Identity;

namespace Pustok_Project.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
        public bool IsAdmin { get; set; }
    }
}
