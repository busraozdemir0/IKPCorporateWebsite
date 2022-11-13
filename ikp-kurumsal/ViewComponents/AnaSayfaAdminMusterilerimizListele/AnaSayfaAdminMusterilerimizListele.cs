using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.AnaSayfaAdminMusterilerimizListele
{
    public class AnaSayfaAdminMusterilerimizListele : ViewComponent
    {
        private readonly IAnaSayfaKisim3Service _anasayfakisim3service;

        public AnaSayfaAdminMusterilerimizListele(IAnaSayfaKisim3Service anasayfakisim3service)
        {
            _anasayfakisim3service = anasayfakisim3service;
        }

        public IViewComponentResult Invoke()
        {
            var anasayfalistesi3 = _anasayfakisim3service.GetList();
            return View(anasayfalistesi3);
        }
    }
}