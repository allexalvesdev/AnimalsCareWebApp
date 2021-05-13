using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVeterinaria.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
    }
}
