using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Core_Bloq_Kamp.ViewComponents
{
    public class DeletedMessage:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            var deletemessage = messageManager.GetListDeletedMessage("qarabagli.murad@mail.ru");
            return View(deletemessage);
        }
    }
}
