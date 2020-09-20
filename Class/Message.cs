using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary8
{
    public class MessagesQueue
    {
        private Queue<Message> messages = new Queue<Message>();

        public void AddMessage(Message message)
        {
            if (messages.Count >= 100)
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
    }
}