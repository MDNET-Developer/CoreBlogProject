using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.ViewComponents
{
    public class GetWriterOnHeader:ViewComponent
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var userinfo = writerManager.GetWriterAccountByID(1);
            return View(userinfo);
        }
    }
}
