using System;

namespace ChatMalta.Domain.Entities
{
    public class Message : EntityBase
    {
        public Message(string message)
        {
            Text = message;
            Date = DateTime.Now;
        }

        public string Text { get; set; }
        public DateTime Date { get; set; }        
    }
}
