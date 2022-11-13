using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.AnasayfaLogo
{
	public class AnasayfaLogo:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			Context c = new Context();
			var logo = c.Logos.Where(x => x.Status == true).FirstOrDefault();

			return View(logo);
			
		}
	}
}
