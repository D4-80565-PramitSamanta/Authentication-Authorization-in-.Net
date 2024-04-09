using Microsoft.AspNetCore.Identity;

namespace IdManagerDemo.Data
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
