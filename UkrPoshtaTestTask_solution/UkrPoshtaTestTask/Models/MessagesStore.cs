using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UkrPoshtaTestTask.Models
{
    public class MessagesStore
    {
        private const int storeUserSize = 3;
        private const int storeGlobalSize = 5;

        public List<Message> Messages { get; set; }

        public MessagesStore()
        {
            Messages = new List<Message>();
        }
        public void Add(Message message)
        {
            bool storeIsFool = Messages.Count == storeGlobalSize;
            List<Message> userMessages = Messages.Where(m => m.User.Name == message.User.Name).ToList();
            bool userOverLimited = userMessages.Count == storeUserSize;

            if (storeIsFool)
            {
                List<Message> tmp = new List<Message>();
                tmp = Messages.GetRange(1, storeGlobalSize-1);
                Messages = tmp;
            }
            if (userOverLimited)
            {
                Messages.Remove(Messages.Where(m => m.User.Name == message.User.Name).OrderBy(m => m.Date).First());
            }
            Messages.Add(message);
        }
    }
}