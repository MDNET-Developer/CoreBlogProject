using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.Controllers
{
    public class NewsLetterController : Controller
    {
        [HttpGet]
        public PartialViewResult SubcribeMailPartial()
        {
            return PartialView();
        }
        [HttpPost]
       public IActionResult SubcribeMailPartial(NewsLetter N)
        {
            NewsLetterManager newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());
            newsLetterManager.TAdd(N);
            return RedirectToAction( "Index","Default");
        }
    }
}
