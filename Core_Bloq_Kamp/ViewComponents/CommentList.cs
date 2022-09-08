using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Bloq_Kamp.ViewComponents
{
	public class CommentList:ViewComponent
	{
		CommentManager commentManager = new CommentManager(new EfCommentRepository());
		public IViewComponentResult Invoke(int id)
		{
			var values = commentManager.TGetList(id);
			return View(values);
		}
	}
}
