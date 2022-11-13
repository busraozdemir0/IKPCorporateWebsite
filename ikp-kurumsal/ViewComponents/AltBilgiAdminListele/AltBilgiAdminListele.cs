using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.AltBilgiListele
{
    public class AltBilgiAdminListele : ViewComponent
    {
        private readonly IAltBilgiService _altbilgiservice;

        public AltBilgiAdminListele(IAltBilgiService altbilgiservice)
        {
            _altbilgiservice = altbilgiservice;
        }

        public IViewComponentResult Invoke()
        {
            var altbilgilistele = _altbilgiservice.GetList();
            return View(altbilgilistele);
        }
    }
}
