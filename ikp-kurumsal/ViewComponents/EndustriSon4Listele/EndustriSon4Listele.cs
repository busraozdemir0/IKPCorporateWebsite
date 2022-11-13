using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.EndustriSon4Listele
{
    public class EndustriSon4Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var endustri = c.endustriAkilliFabrikas.OrderByDescending(x => x.EndustriAkilliFabrika_id).Take(4).ToList();
            return View(endustri);
        }
    }
}
