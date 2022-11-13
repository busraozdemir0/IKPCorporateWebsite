using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.UretimTakipSon4Listele
{
    public class UretimTakipSon4Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var uretim = c.uretimTakipYonetimis.OrderByDescending(x => x.UretimTakip_id).Take(4).ToList();
            return View(uretim);
        }
    }
}
