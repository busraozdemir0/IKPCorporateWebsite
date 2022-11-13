using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.AnaSayfaAdminCozumlerimizListele
{
    public class AnaSayfaAdminCozumlerimizListele : ViewComponent
    {
        private readonly IAnaSayfaKisim2Service _anasayfakisim2service;

        public AnaSayfaAdminCozumlerimizListele(IAnaSayfaKisim2Service anasayfakisim2service)
        {
            _anasayfakisim2service = anasayfakisim2service;
        }

        public IViewComponentResult Invoke()
        {
            var anasayfalistesi2 = _anasayfakisim2service.GetList();
            return View(anasayfalistesi2);
        }
    }
}