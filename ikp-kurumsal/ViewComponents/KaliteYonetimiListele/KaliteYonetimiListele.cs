using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.KaliteYonetimiListele
{
    public class KaliteYonetimiListele:ViewComponent
    {
        private readonly IKaliteYonetimiService _kaliteYonetimiService;

        public KaliteYonetimiListele(IKaliteYonetimiService kaliteYonetimiService)
        {
            _kaliteYonetimiService = kaliteYonetimiService;
        }

        public IViewComponentResult Invoke()
        {
            var kaliteyonetimiliste = _kaliteYonetimiService.GetList();
            return View(kaliteyonetimiliste);
        }
    }
}
