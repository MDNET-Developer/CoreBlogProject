using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Bloq_Kamp.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v1 = usermail;
            FriendManager friendManager = new FriendManager(new EfFriendRepository());
            var friendlist = friendManager.GetFriendList(usermail);
            return View(friendlist);
        }

        public IActionResult UserFriendBlogs(string id)
        {
            WriterManager writerManager = new WriterManager(new EfWriterRepository());
            var detallar = writerManager.GetWiterbyFriend(id);
            return View(detallar);
        }

        [HttpGet]
        public IActionResult SendMessage(string id)
        {
            WriterManager writerManager = new WriterManager(new EfWriterRepository());
            var detallar = writerManager.GetWiterbyFriend(id);
            ViewBag.sender = User.Identity.Name;
            return View(detallar);
        }
        [HttpPost]
        public IActionResult SendMessage(Message m)
        {
            MessageManager messageManager = new MessageManager(new EfMessageRepository());
            m.MessageDateTime = DateTime.Now;
            m.MessageStatus = true;
            messageManager.TAdd(m);
            return RedirectToAction("Index","Message");
        }

    }
}
