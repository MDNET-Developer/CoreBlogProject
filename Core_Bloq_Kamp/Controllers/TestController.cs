using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
