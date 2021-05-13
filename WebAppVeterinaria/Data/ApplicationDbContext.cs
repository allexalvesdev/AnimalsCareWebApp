using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppVeterinaria.Entity;
using WebAppVeterinaria.ViewModels;

namespace WebAppVeterinaria.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ApplicationUser> Usuarios { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
