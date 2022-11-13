using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.ilanBasvuranBilgiListele
{
    public class ilanBasvuranBilgiListele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();

            var username = User.Identity.Name;
            var userid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var basvurankisiler = c.isilanlaris.Where(x => x.AppUser.UserName == username).Include(x => x.IsBasvuruTbls).ThenInclude(y => y.AppUser).ToList();

            var ilanlarin_idsi = c.isilanlaris.Where(x => x.AppUserId == userid).Select(y => y.Id).ToList();
            var basvuru_yapanlar_id = c.IsBasvuruTbls.Where(x => ilanlarin_idsi.Contains(x.isilanlariId)).Select(y => y.AppUserId).ToList();
            var basvuru_yapanlar_cv = c.isArayanBilgis.Where(x => basvuru_yapanlar_id.Contains(x.AppUserId)).Include(x => x.AppUser).ToList();
            //ViewBag.cv = basvuru_yapanlar_cv;
            return View(basvuru_yapanlar_cv);
        }
    }
}
