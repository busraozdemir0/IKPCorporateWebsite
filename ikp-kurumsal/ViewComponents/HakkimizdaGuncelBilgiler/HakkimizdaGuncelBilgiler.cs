using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.HakkimizdaGuncelBilgiler
{
    public class HakkimizdaGuncelBilgiler:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var bilgi = c.hakkimizdaGuncelBilgilers.FirstOrDefault();
            return View(bilgi);
        }
        
    }
}
