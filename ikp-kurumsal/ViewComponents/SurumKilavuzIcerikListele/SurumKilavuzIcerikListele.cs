using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.SurumKilavuzIcerikListele
{
    public class SurumKilavuzIcerikListele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var surumkilavuzuicerikListe = c.surumKilavuzIceriks.Where(x => x.SurumKilavuzuSurumKilavuz_Id == x.SurumKilavuzu.SurumKilavuz_Id).Include(y => y.SurumKilavuzu).ToList();
            return View(surumkilavuzuicerikListe);
        }
    }
}
