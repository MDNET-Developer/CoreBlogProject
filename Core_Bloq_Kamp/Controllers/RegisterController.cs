using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.WriterValidator;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new  WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer w)
        {
            WriterValidator rules = new WriterValidator();
            ValidationResult validationResult = rules.Validate(w);
            if (validationResult.IsValid)
            {
                w.WriterStatus = true;
                writerManager.TAdd(w);
                return RedirectToAction("Login","Index");
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
