using DesignPattern.Decorator.DataAccessLayer;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class MailDecorator : Decorator
    {
        private readonly INotifier _notifier;
        Context context = new Context();
        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }
        public void SendMailNotify(Notifier notifier)
        {
            notifier.NotifierSubject = "Günlük Sabah Toplantısı";
            notifier.NotifierCreator = "Scrum Master";
            notifier.NotiferChannel = "GMail-Outlook";
            notifier.NotfierType = "Private Team";
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
            SendMailNotify(notifier);
        }
    }
}
