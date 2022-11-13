using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.AdminLogoListele
{
	public class AdminLogoListele:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			Context c = new Context();
			var Logo = c.Logos.ToList();
			return View(Logo);
		}
	}
}
