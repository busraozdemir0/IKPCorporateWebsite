using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.HaberSon4Listele
{
    public class HaberSon4Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var haber = c.habers.OrderByDescending(x => x.Haber_id).Take(4).ToList();
            return View(haber);
        }
    }
}
