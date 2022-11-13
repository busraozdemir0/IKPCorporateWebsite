using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.UretimTakipSon3Listele
{
    public class UretimTakipSon3Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var uretimSon3Liste = context.uretimTakipYonetimis.OrderByDescending(x => x.UretimTakip_id).Take(3).ToList();
            return View(uretimSon3Liste);
        }
    }
}
