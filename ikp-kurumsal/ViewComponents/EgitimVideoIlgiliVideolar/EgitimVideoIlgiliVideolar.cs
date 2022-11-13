using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.EgitimVideoIlgiliVideolar
{
    public class EgitimVideoIlgiliVideolar : ViewComponent
    {
        private readonly IVideoKategoriService _videokategoriservice;
        private readonly IEgitimVideolariService _egitimvideolariservice;

        public EgitimVideoIlgiliVideolar(IVideoKategoriService videokategoriservice, IEgitimVideolariService egitimvideolariservice)
        {
            _videokategoriservice = videokategoriservice;
            _egitimvideolariservice = egitimvideolariservice;
        }

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var videolar = c.VideoKategoris.Take(4).ToList();
            return View(videolar);
        }
    }
}
