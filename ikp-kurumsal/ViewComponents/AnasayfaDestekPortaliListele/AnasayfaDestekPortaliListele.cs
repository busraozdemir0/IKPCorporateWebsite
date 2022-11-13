using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.AnasayfaDestekPortaliListele
{
    public class AnasayfaDestekPortaliListele:ViewComponent
    {
        private readonly IDestekPortaliService _destekportaliservice;

        public AnasayfaDestekPortaliListele(IDestekPortaliService destekportaliservice)
        {
            _destekportaliservice = destekportaliservice;
        }

        public IViewComponentResult Invoke()
        {
            var destekportali = _destekportaliservice.GetList();
            return View(destekportali);
        }
    }
}
