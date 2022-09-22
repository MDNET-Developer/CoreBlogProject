using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Bloq_Kamp.ViewComponents
{
    public class MessageNav:ViewComponent
    {
        //MessageManager messageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            ViewBag.gelen = c.Messages.Where(x => x.Receiver == usermail && x.MessageStatus==true).Count();
            ViewBag.gonderilen = c.Messages.Where(x => x.Sender == usermail).Count();
            return View();
        }
    }
}
