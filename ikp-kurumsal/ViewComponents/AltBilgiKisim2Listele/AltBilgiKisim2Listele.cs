using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.AltBilgiKisim2Listele
{
    public class AltBilgiKisim2Listele : ViewComponent
    {
        private readonly IAltBilgiService _altbilgiservice;

        public AltBilgiKisim2Listele(IAltBilgiService altbilgiservice)
        {
            _altbilgiservice = altbilgiservice;
        }

        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var baslik2 = context.altBilgis.FirstOrDefault();
            ViewBag.v = baslik2.Baslik2;
            var altbilgi2listele = _altbilgiservice.GetList();
            return View(altbilgi2listele);
        }
    }
}
