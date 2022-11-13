using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.IsVerenLayoutIsim
{
    public class IsVerenLayoutIsim:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var userName = User.Identity.Name;
            var adSoyad = c.Users.Where(x => x.UserName == userName).Select(y => y.namesurname).FirstOrDefault();
            ViewBag.adısoyadı = adSoyad;
            return View();
        }
    }
}
