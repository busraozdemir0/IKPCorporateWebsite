using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.DestekPortaliListele
{
    public class DestekPortaliListele:ViewComponent
    {
        private readonly IDestekPortaliService _destekportaliservice;

        public DestekPortaliListele(IDestekPortaliService destekportaliservice)
        {
            _destekportaliservice = destekportaliservice;
        }

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var baslik = c.destekPortalis.FirstOrDefault();
            ViewBag.baslik = baslik.DestekPortali_Baslik;
            var destekportalilistesi = _destekportaliservice.GetList();
            return View(destekportalilistesi);
        }
    }
}
