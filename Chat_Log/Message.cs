using System.Collections.Generic;
using System.Linq;

namespace Chat_Log
{
    public class MessagesQueue
    {
        private Queue<Message> messages = new Queue<Message>();

        public void AddMessage(Message message)
        {
            if (messages.Count >= Core.Instance.Settings.MaxLogMessages)
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
