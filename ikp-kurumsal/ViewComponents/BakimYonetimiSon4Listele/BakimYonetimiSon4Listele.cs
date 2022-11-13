using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.BakimYonetimiSon4Listele
{
    public class BakimYonetimiSon4Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var bakim = c.bakimYonetimis.OrderByDescending(x => x.BakimYonetimi_id).Take(4).ToList();
            return View(bakim);
        }
    }
}
