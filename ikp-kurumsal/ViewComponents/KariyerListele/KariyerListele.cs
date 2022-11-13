using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.KariyerListele
{
    public class KariyerListele:ViewComponent
    {
        private readonly IKariyerService _kariyerService;

        public KariyerListele(IKariyerService kariyerService)
        {
            _kariyerService = kariyerService;
        }

        public IViewComponentResult Invoke()
        {
            var kariyerListe = _kariyerService.GetList();
            return View(kariyerListe);
        }
    }
}
