using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.BakimYonetimiListele
{
    public class BakimYonetimiListele:ViewComponent
    {
        private readonly IBakimYonetimiService _bakimyonetimiservice;

        public BakimYonetimiListele(IBakimYonetimiService bakimyonetimiservice)
        {
            _bakimyonetimiservice = bakimyonetimiservice;
        }

        public IViewComponentResult Invoke()
        {
            var bakimyonetimilistesi = _bakimyonetimiservice.GetList();
            return View(bakimyonetimilistesi);
        }
    }
}
