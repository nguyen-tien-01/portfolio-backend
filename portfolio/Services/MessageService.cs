using portfolio.Context;
using portfolio.Entities;
using portfolio.Interfaces;

namespace portfolio.Services
{
    public class MessageService : IMessageService
    {
        private AppDbContext context;
        public MessageService()
        {
            context = new AppDbContext();
        }
        public IQueryable<Message> GetMessages()
        {
            var message = context.Message.AsQueryable();
            return message;
        }

        public Message ThemMessage(Message message)
        {
            message.dateTime = DateTime.Now;
            context.Add(message);
            context.SaveChanges();
            return message;
        }
    }
}
