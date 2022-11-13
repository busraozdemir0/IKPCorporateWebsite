using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.WebMobilSon3Listele
{
    public class WebMobilSon3Listele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var webSon3Liste = context.webMobils.OrderByDescending(x => x.WebMobil_id).Take(3).ToList();
            return View(webSon3Liste);
        }
    }
}
