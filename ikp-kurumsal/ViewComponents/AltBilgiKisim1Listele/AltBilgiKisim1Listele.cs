using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.AltBilgiKisim1Listele
{
    public class AltBilgiKisim1Listele:ViewComponent
    {
        private readonly IiletisimService _iletisimservice;

        public AltBilgiKisim1Listele(IiletisimService iletisimservice)
        {
            _iletisimservice = iletisimservice;
        }

        public IViewComponentResult Invoke()
        {
            var altbilgi1listele = _iletisimservice.GetList();
            return View(altbilgi1listele);
        }
    }
}
