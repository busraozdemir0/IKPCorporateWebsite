using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.AnaSayfaAdminSliderListele
{
    public class AnaSayfaAdminSliderListele : ViewComponent
    {
        private readonly IAnaSayfaKisim1Service _anasayfakisim1service;

        public AnaSayfaAdminSliderListele(IAnaSayfaKisim1Service anasayfakisim1service)
        {
            _anasayfakisim1service = anasayfakisim1service;
        }

        public IViewComponentResult Invoke()
        {
            var anasayfalistesi1 = _anasayfakisim1service.GetList();
            return View(anasayfalistesi1);
        }
    }
}