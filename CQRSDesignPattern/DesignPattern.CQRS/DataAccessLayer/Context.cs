using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TUNA\\SQLEXPRESS;Database=CQRS;Integrated Security=true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
