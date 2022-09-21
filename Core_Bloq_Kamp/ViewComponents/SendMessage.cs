using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Bloq_Kamp.ViewComponents
{
    
    public class SendMessage:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            var sendmessage = messageManager.GetListMessageByWriter("qarabagli.murad@mail.ru");
            return View(sendmessage);
        }
    }
}
