using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.DilSecenekleri
{
    public class DilSecenekleri: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var diller = c.dilTablosus.ToList();
            return View(diller);
        }
    }
}
