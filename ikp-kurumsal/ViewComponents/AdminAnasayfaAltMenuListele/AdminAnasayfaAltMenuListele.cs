using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.AdminAnasayfaAltMenuListele
{
    public class AdminAnasayfaAltMenuListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var altmenuler = c.anasayfaAltMenus.Where(x => x.AnasayfaMenuId == x.AnasayfaMenu.Id).Include(x => x.AnasayfaMenu).ToList();
            
            return View(altmenuler);
        }
    }
}
