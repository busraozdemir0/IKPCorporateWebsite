using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.EgitimVideoDetaySayfası
{
    public class EgitimVideoDetaySayfası:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            var egitimvideo = context.egitimVideolaris.ToList().Where(x => x.EgitimVideo_Id == id);
            return View(egitimvideo);
        }
    }
}
