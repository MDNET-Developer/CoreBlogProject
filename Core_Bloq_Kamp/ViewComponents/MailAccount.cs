using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_Bloq_Kamp.ViewComponents
{
    public class MailAccount:ViewComponent
    {
        WriterManager writerManager = new  WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var userid = c.Writers.Where(x => x.WriterMail == User.Identity.Name).Select(x => x.WriterID).FirstOrDefault();
            var user = writerManager.GetWriterAccountByID(userid);
            return View(user);
        }
    }
}
