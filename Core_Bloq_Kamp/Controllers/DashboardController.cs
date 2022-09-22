using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Bloq_Kamp.Controllers
{
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context db = new Context();
            var userid = db.Writers.Where(x => x.WriterMail == User.Identity.Name).Select(x => x.WriterID).FirstOrDefault();
            ViewBag.blog = db.Blogs.Where(x => x.WriterID == userid).Count();

            return View();
        }
    }
}
