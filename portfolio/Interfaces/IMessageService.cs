using portfolio.Entities;

namespace portfolio.Interfaces
{
    public interface IMessageService
    {
        public IQueryable<Message> GetMessages();
        public Message ThemMessage (Message message);

    }
}
