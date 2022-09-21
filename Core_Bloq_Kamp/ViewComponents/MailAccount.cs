using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Core_Bloq_Kamp.ViewComponents
{
    public class MailAccount:ViewComponent
    {
        WriterManager writerManager = new  WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var user = writerManager.GetWriterAccountByID(1);
            return View(user);
        }
    }
}
