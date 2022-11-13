using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.MailBultenListele
{
    public class MailBultenListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var mailbültenList = c.MailBultenis.ToList();
            return View(mailbültenList);
        }
    }
}
