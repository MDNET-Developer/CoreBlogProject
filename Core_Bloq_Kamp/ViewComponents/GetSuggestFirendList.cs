using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.ViewComponents
{
    public class GetSuggestFirendList : ViewComponent
    {
        FriendManager friendManager = new FriendManager(new EfFriendRepository());
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var suggestfriend = friendManager.GetSuggestFriendList(usermail);
            return View(suggestfriend);
        }
    }
}
