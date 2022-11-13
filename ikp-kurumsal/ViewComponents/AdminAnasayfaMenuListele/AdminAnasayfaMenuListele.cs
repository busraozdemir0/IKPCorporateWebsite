using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.AdminAnasayfaMenuListele
{
    public class AdminAnasayfaMenuListele:ViewComponent
    {
        private readonly IAnasayfaMenuService _anasayfamenuservice;

        public AdminAnasayfaMenuListele(IAnasayfaMenuService anasayfamenuservice)
        {
            _anasayfamenuservice = anasayfamenuservice;
        }

        public IViewComponentResult Invoke()
        {
            var menuler = _anasayfamenuservice.GetList();
            return View(menuler);
        }
    }
}
