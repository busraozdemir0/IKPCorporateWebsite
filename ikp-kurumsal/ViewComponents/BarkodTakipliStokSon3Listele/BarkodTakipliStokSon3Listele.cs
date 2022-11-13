using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.BarkodTakipliStokSon3Listele
{
    public class BarkodTakipliStokSon3Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var barkodtakip = c.barkodTakipStoks.OrderByDescending(x => x.BarkodTakipStok_id).Take(3).ToList();
            return View(barkodtakip);
        }
    }
}
