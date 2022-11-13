using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.KariyerSon3Listele
{
    public class KariyerSon3Listele:ViewComponent
    {        
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var kariyerSon3Liste = context.kariyers.OrderByDescending(x => x.Kariyer_id).Take(3).ToList();
            return View(kariyerSon3Liste);
        }
    }
}
