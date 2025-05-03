using DesignPattern.Decorator.DataAccessLayer;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class CreateNotifier : INotifier
    {
        Context context = new Context();
        public void CreateNotify(Notifier notifier)
        {
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
    }
}
