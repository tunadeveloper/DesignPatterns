using DesignPattern.Decorator.DataAccessLayer;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class CreateNotifier : INotifier
    {
        private readonly Context _context;

        public CreateNotifier(Context context)
        {
            _context = context;
        }

        public void CreateNotify(Notifier notifier)
        {
          _context.Notifiers.Add(notifier);
            _context.SaveChanges();
        }
    }
}
