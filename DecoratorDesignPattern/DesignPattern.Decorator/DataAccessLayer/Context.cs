using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Decorator.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TUNA\\SQLEXPRESS;Database=DecoratorDP;Integrated Security=true;");
        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notifier> Notifiers { get; set; }
    }
}
