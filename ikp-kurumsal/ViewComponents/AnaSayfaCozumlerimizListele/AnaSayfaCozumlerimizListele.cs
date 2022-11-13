using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.AnaSayfaCozumlerimizListele
{
    public class AnaSayfaCozumlerimizListele : ViewComponent
    {
        private readonly IAnaSayfaKisim2Service _anasayfakisim2service;

        public AnaSayfaCozumlerimizListele(IAnaSayfaKisim2Service anasayfakisim2service)
        {
            _anasayfakisim2service = anasayfakisim2service;
        }

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var liste = c.anaSayfaKisim2s.ToList();
            return View(liste);
        }
    }
}