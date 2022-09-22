using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.BlogValidator;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core_Bloq_Kamp.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
    
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            Context c = new Context();
            var userid = c.Writers.Where(x => x.WriterMail == User.Identity.Name).Select(x => x.WriterID).FirstOrDefault();
            var bloqlar = blogManager.GetListWithCategoryByWriter(userid);
            return View(bloqlar);
        }
        [HttpGet]
        public IActionResult YeniBlog()
        {
            CategoryManager CM = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categorylist = (from x in CM.TGetList()
                                                 select new SelectListItem
                                                 {
                                                     Text=x.CategoryName,
                                                     Value=x.CategoryID.ToString()
                                                 }
                                                 ).ToList();
            ViewBag.CategoryList = categorylist;
           
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
                Context c = new Context();
                var userid = c.Writers.Where(x => x.WriterMail == User.Identity.Name).Select(x => x.WriterID).FirstOrDefault();
                b.WriterID = userid;
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

        //Yenileme kodlari
        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            CategoryManager CM = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categorylist = (from x in CM.TGetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryID.ToString()
                                                 }
                                                 ).ToList();
            ViewBag.CategoryList = categorylist;
            var element = blogManager.GetByID(id);
            return View(element);
        }
        [HttpPost]
        public IActionResult BlogEdit(Blog b)
        {
            Context c = new Context();
            var userid = c.Writers.Where(x => x.WriterMail == User.Identity.Name).Select(x => x.WriterID).FirstOrDefault();
            b.WriterID = userid;
            b.BlogStatus = true;
            blogManager.TUpdate(b);
            return RedirectToAction("Index", "Writer");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult WriterInfo()
        {
            WriterManager writerManager = new WriterManager(new EfWriterRepository());
            Context c = new Context();
            var userid = c.Writers.Where(x => x.WriterMail == User.Identity.Name).Select(x => x.WriterID).FirstOrDefault();
            var userinfo = writerManager.GetByID(userid);
            return View(userinfo);
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult WriterInfo(Writer p)
        {
            WriterManager writerManager = new WriterManager(new EfWriterRepository());
            writerManager.TUpdate(p);
            return View();
        }
    }
}
