using Microsoft.EntityFrameworkCore;

namespace ClientesApp.Models
{
    public class ClientesBDContext: DbContext
    {

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-AI06HEJ8;Database=ClientesBD;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
    
}
