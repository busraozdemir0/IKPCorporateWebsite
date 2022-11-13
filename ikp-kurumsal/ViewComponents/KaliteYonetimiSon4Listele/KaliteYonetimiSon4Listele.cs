using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.KaliteYonetimiSon4Listele
{
    public class KaliteYonetimiSon4Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var kalite = c.kaliteYonetimis.OrderByDescending(x => x.KaliteYonetimi_Id).Take(4).ToList();
            return View(kalite);
        }
    }
}
