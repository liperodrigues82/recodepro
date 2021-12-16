using Microsoft.EntityFrameworkCore;

namespace Recodetour.Models
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PFHLVPM;Initial Catalog=Recodetour;Integrated Security=True");
        }
    }
}
