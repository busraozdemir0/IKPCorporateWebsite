using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.IKIsilanlariListele
{
    public class IKIsilanlariListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var ilanlar = c.isilanlaris.Where(x => x.Status == true).ToList();
            return View(ilanlar);
        }
    }
}
