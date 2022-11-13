using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.isverendashboardisbasvurulistele
{
    public class isverendashboardisarayanlistele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var isarayanlar = c.IsBasvuruTbls.Include(x => x.AppUser).ToList();
            return View(isarayanlar);
        }
    }
}
