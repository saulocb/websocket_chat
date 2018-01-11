namespace ChatMalta.Domain.Entities
{
    public class Sender : EntityBase
    {
        public Sender(string message)
        {
            Message = new Message(message);
        }

        public Message Message { get; set; }
    }
}
