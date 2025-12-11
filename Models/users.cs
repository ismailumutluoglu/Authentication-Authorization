using Microsoft.AspNetCore.Identity;

namespace Authentication.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}