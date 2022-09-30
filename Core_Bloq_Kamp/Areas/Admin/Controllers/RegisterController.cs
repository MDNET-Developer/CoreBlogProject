using Core_Bloq_Kamp.Areas.Admin.Models;
using EntityLayer.Concrete;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Bloq_Kamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        public readonly UserManager<AppUser>    _userManager;
        private object item;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    NameSurname = userRegisterViewModel._NameSurname,
                    Email = userRegisterViewModel._Email,
                    UserName=userRegisterViewModel._Username
                };
                var registration = await _userManager.CreateAsync(appUser,userRegisterViewModel._Password);
                if (registration.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in registration.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                   
                }
            }
            return View();
        }
    }
}
