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
            ViewBag.gelen = c.Messages.Where(x => x.Receiver == "qarabagli.murad@mail.ru" && x.MessageStatus==true).Count();
            ViewBag.gonderilen = c.Messages.Where(x => x.Sender == "qarabagli.murad@mail.ru").Count();
            return View();
        }
    }
}
