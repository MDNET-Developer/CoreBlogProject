using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Bloq_Kamp.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageController = new MessageManager(new EfMessageRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    
    }
}
