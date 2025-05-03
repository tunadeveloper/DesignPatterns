using DesignPattern.Decorator.DataAccessLayer;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public SubjectIDDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageIDSubject(Message message)
        {
           switch(message.MessageSubject)
            {
                case "1":
                    message.MessageSubject = "Toplantı";
                    break;
                case "2":
                    message.MessageSubject = "Scrum Toplantısı";
                    break;
                case "3":
                    message.MessageSubject = "Haftalık Değerlendirme";
                    break;
                default:
                    message.MessageSubject = "Diğer";
                    break;
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageIDSubject(message);
        }
    }
}
