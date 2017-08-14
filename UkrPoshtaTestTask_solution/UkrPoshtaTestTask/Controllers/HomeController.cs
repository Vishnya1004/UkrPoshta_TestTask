using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UkrPoshtaTestTask.Models;

namespace UkrPoshtaTestTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.showMessagesNow = false;
            return View();
        }

        public ActionResult Index2()
        {
            ViewBag.showMessagesNow = true;
            return View("Index");
        }

        [HttpPost]
        public ActionResult CreateMessage(string userName, string messageBody)
        {
            Message message = new Message(messageBody, userName);
            MessagesStore ms =(MessagesStore)System.Web.HttpContext.Current.Application["messagesStore"];
            ms.Add(message);
            return RedirectToAction("Index");
        }

        public ActionResult ShowAllMessages()
        {
            MessagesStore ms = new MessagesStore();
            ms = (MessagesStore)System.Web.HttpContext.Current.Application["messagesStore"];
           
            return PartialView("_Messages", ms);
        }

        public ActionResult GroupMessagesByUsers()
        {
            MessagesStore ms = new MessagesStore();
            ms = (MessagesStore)System.Web.HttpContext.Current.Application["messagesStore"];
            var groupedMessages = ms.Messages.GroupBy(u => u.User.Name);
            return PartialView("_UserMessages", groupedMessages);
        }


    }
}