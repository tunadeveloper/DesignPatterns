using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibilty.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TUNA\\SQLEXPRESS;Database=ChainOfResponsibility;Integrated Security=true;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
