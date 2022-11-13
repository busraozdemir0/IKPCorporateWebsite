using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.ReferansSon4Listele
{
    public class ReferansSon4Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var referans = c.referanslars.OrderByDescending(x => x.Referanslar_id).Take(4).ToList();
            return View(referans);
        }
    }
}
