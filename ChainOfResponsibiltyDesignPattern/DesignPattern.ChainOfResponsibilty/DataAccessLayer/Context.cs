using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TUNA\\SQLEXPRESS;Database=COR;Integrated Security=true;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
