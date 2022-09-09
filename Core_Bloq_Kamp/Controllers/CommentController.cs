using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment c)
        {
            commentManager.TAdd(c);
            return RedirectToAction("Index", "Default");

        }
            public PartialViewResult ListCommentByBlog(int id)
        {
            var values = commentManager.TGetList(id);
            return PartialView(values);
        }
    }
}
