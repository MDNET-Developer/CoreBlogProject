using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Bloq_Kamp.ViewComponents
{
    public class NotifcationList:ViewComponent
    {
        NotifcationManager notifcationManager = new NotifcationManager(new EfNotifcationRepository());
        public IViewComponentResult Invoke()
        {
            Context db = new Context();
            var bildirissayi = db.Notifcations.Count().ToString();
            ViewBag.v1 = bildirissayi;
            var bildirimler = notifcationManager.TGetList();
            return View(bildirimler);
        }
    }
}
