using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.ViewComponents
{
    public class Last3PostFooterList:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var x = blogManager.GetLast3BlogsFooter();
            return View(x);
        }
    }
}
