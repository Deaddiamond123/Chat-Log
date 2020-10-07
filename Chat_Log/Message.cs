using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary8
{
    public class MessagesQueue
    {
        private Queue<Message> messages = new Queue<Message>();

        public void AddMessage(Message message)
        {
            if (messages.Count >= 300)
            {
                messages.Dequeue();
            }

            messages.Enqueue(message);
        }

        public Message[] Messages
        {
            get { return messages.Reverse().ToArray(); }
        }
    }

    public class Message
    {
        public string Author { get; set; }

        public string Content { get; set; }

        public string Type { get; set; }

        public Message(string Author, string Content, string Type)
        {
            this.Author = Author;
            this.Content = Content;
            this.Type = Type;
        }
    }
}
