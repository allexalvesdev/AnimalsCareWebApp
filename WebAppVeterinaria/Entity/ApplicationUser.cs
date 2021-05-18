using Microsoft.AspNetCore.Identity;

namespace WebAppVeterinaria.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
    }
}
