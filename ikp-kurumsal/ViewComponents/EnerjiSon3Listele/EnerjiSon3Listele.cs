using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.EnerjiSon3Listele
{
    public class EnerjiSon3Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var enerjiSon3Liste = context.enerjiYonetimis.OrderByDescending(x => x.EnerjiYonetimi_Id).Take(3).ToList();
            return View(enerjiSon3Liste);
        }
    }
}
