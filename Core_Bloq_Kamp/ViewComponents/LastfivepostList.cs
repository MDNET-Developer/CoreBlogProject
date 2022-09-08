using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Bloq_Kamp.ViewComponents
{
    public class LastfivepostList:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            var x = blogManager.GetLast5Blogs(id);
            return View(x);
        }
    }
}
