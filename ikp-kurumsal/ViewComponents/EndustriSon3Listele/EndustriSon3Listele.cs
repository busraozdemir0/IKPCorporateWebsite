using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.EndustriSon3Listele
{
    public class EndustriSon3Listele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var endustriSon3Liste = context.endustriAkilliFabrikas.OrderByDescending(x => x.EndustriAkilliFabrika_id).Take(3).ToList();
            return View(endustriSon3Liste);
        }
    }
}
