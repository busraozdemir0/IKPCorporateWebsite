using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.IsArayanLayoutIsim
{
    public class IsArayanLayoutIsim:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var namesurname = c.Users.Where(x => x.UserName == username).Select(y => y.namesurname).FirstOrDefault();
            ViewBag.namesurname = namesurname;
            return View();
        }
    }
}
