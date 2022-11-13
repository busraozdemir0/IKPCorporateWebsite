using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.EntegreSon4Listele
{
    public class EntegreSon4Listele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var entegre = c.entegreSistems.OrderByDescending(x => x.EntegreSistem_id).Take(4).ToList();
            return View(entegre);
        }
    }
}
