using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TUNA\\SQLEXPRESS;Database=MediatorDP;Integrated Security=true;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
