using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.AnaSayfaAdminPortfolyoListele
{
    public class AnaSayfaAdminPortfolyoListele : ViewComponent
    {
        private readonly IAnaSayfaKisim4Service _anasayfakisim4service;

        public AnaSayfaAdminPortfolyoListele(IAnaSayfaKisim4Service anasayfakisim4service)
        {
            _anasayfakisim4service = anasayfakisim4service;
        }

        public IViewComponentResult Invoke()
        {
            var anasayfalistesi4 = _anasayfakisim4service.GetList();
            return View(anasayfalistesi4);
        }
    }
}