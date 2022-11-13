using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.WebMobilSon4Listele
{
    public class WebMobilSon4Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var web = c.webMobils.OrderByDescending(x => x.WebMobil_id).Take(4).ToList();
            return View(web);
        }
    }
}
