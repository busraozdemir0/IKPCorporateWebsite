using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.EnerjiYonetimiSon4Listele
{
    public class EnerjiYonetimiSon4Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var enerji = c.enerjiYonetimis.OrderByDescending(x => x.EnerjiYonetimi_Id).Take(4).ToList();
            return View(enerji);
        }
    }
}
