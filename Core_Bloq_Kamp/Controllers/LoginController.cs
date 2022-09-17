using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_Bloq_Kamp.Controllers
{
    public class LoginController : Controller
    {
      
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer w)
        {
            Context db = new Context();
            var datavalue = db.Writers.FirstOrDefault(x => x.WriterMail == w.WriterMail && x.WriterPassword == w.WriterPassword);
            if (datavalue != null)
            {
                //telebleri listeleyir
                var telebler = new List<Claim>
                {

                    new Claim(ClaimTypes.Name,w.WriterMail)
                };

                var useridentity = new ClaimsIdentity(telebler, "a");
                //teleb prinsipleri
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                //kuki yaratmaq ucun gelen istifadeci formatini
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Default");
            }
           else
           {
                 return View();
           }
        }

    }
            
           
}

