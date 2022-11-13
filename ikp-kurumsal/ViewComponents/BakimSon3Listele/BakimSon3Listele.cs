using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.BakimSon3Listele
{
    public class BakimSon3Listele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var bakimSon3Liste = context.bakimYonetimis.OrderByDescending(x => x.BakimYonetimi_id).Take(3).ToList();
            return View(bakimSon3Liste);
        }
    }
}
