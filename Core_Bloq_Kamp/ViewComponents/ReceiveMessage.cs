using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Bloq_Kamp.ViewComponents
{
    public class ReceiveMessage:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            var inbox = messageManager.GetListInboxMessage("qarabagli.murad@mail.ru");
            return View(inbox);
        }
    }
}
