using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UkrPoshtaTestTask.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public User(String name)
        {
            if (String.IsNullOrEmpty(name))
            {
                Name = "NoName";
            }
            else
            {
                Name = name;
            }
        }
    }
}