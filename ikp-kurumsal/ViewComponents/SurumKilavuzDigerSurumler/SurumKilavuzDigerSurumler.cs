using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.SurumKilavuzDigerSurumler
{
    public class SurumKilavuzDigerSurumler : ViewComponent
    {

        
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var surumdiger = c.surumKilavuzus.Take(5).ToList();
            return View(surumdiger);
        }
    }
}
