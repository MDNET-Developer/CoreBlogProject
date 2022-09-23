using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
