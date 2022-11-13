using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.AnaSayfaMusterilerimizListele
{
    public class AnaSayfaMusterilerimizListele : ViewComponent
    {
        private readonly IAnaSayfaKisim3Service _anasayfakisim3service;

        public AnaSayfaMusterilerimizListele(IAnaSayfaKisim3Service anasayfakisim3service)
        {
            _anasayfakisim3service = anasayfakisim3service;
        }

        public IViewComponentResult Invoke()
        {
            var anasayfalistesi = _anasayfakisim3service.GetList();
            return View(anasayfalistesi);
        }
    }
}