using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.AdminLayoutIsim
{
    public class AdminLayoutIsim:ViewComponent
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
