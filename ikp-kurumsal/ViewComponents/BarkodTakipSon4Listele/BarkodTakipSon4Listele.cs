using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.BarkodTakipSon4Listele
{
    public class BarkodTakipSon4Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var stok = c.barkodTakipStoks.OrderByDescending(x => x.BarkodTakipStok_id).Take(4).ToList();
            return View(stok);
        }
    }
}
