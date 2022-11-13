using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.AnasayfaMenuListele
{
    public class AnasayfaMenuListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            //var menuler = c.anasayfaAltMenus.Where(x => x.AnasayfaMenuId == x.Id).Include(y => y.AnasayfaMenu).ToList();
            var menuler = c.anasayfaMenus.Include(y => y.anasayfaAltMenus).ToList();

            return View(menuler);
        }
    }
}
                                      