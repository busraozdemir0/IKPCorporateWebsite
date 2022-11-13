using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.KaliteYonetimiSon3Listele
{
    public class KaliteYonetimiSon3Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var kaliteyonetimi = c.kaliteYonetimis.OrderByDescending(x => x.KaliteYonetimi_Id).Take(3).ToList();
            return View(kaliteyonetimi);
        }
    }
}
