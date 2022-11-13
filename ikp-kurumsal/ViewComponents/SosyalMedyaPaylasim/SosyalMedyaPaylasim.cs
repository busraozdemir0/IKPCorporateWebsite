using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.SosyalMedyaPaylasim
{
    public class SosyalMedyaPaylasim:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var paylasimlar = c.sosyalMedyaPaylasims.FirstOrDefault();
            return View(paylasimlar);
        }
    }
}
