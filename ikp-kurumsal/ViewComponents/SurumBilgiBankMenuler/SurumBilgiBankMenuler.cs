using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.SurumBilgiBankMenuler
{
    public class SurumBilgiBankMenuler : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            Context c = new Context();
            var bilgibankmenuad = c.anasayfaMenus.Where(x => x.Id == 7).Select(y => y.MenuIsim).FirstOrDefault();
            ViewBag.menuad = bilgibankmenuad;

            var bilgibankmenu = c.anasayfaAltMenus.Where(x => x.AnasayfaMenu.MenuIsim == "Bilgi Bankasi").ToList();
            return View(bilgibankmenu);
        }
    }
}
