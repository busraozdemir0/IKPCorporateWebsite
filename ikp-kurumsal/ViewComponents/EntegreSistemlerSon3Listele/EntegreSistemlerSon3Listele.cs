using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.EntegreSistemlerSon3Listele
{
    public class EntegreSistemlerSon3Listele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var entegreSon3Liste = context.entegreSistems.OrderByDescending(x => x.EntegreSistem_id).Take(3).ToList();
            return View(entegreSon3Liste);
        }
    }
}
