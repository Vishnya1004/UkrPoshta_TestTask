using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UkrPoshtaTestTask.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public String Body { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }

        public Message(String body, String userName )
        {
            Id = Guid.NewGuid();

            if (String.IsNullOrEmpty(body))
            {
                Body = "Empty message";
            }
            else
            {
                Body = body;
            }
            User = new User(userName);
            Date = DateTime.Now;
        }
    }
}