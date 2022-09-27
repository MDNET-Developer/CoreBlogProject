using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.CategoryValidator;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Core_Bloq_Kamp.Areas.Admin.Controllers
{

    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
     
      
      
        public IActionResult Index(int page=1)
        {
            
            var kateqoriyalar = categoryManager.TGetList().ToPagedList(page,3);
            return View(kateqoriyalar);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult YeniKateqoriya()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult YeniKateqoriya(Category c)
        {
            CategoryValidator validationRules = new CategoryValidator();
            ValidationResult validationResult = validationRules.Validate(c);
            if (validationResult.IsValid)
            {
                categoryManager.TAdd(c);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    
                }
                return View();
            }
           
        }
    }
}
