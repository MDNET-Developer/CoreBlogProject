using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.BlogValidator;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Bloq_Kamp.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
    
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var bloqlar = blogManager.GetBlogListByWriter(1);
            return View(bloqlar);
        }
        [HttpGet]
        public IActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniBlog(Blog b)
        {
            BlogValidator blogValidator = new BlogValidator();
           ValidationResult validationResult = blogValidator.Validate(b);
            if (validationResult.IsValid)
            {
                b.BlogStatus = true;
                b.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
                b.WriterID =1 ;
                blogManager.TAdd(b);
                return RedirectToAction("Index", "Writer");
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


        public IActionResult DeleteBlog(int id)
        {
            var getid = blogManager.GetByID(id);
            blogManager.TDelete(getid);
            return RedirectToAction("Index","Writer");
        }
    }
}
