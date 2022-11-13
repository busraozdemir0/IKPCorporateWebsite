using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.EnerjiYonetimiListele
{
    public class EnerjiYonetimiListele:ViewComponent
    {
        private readonly IEnerjiYonetimiService _enerjiYonetimiService;
public EnerjiYonetimiListele(IEnerjiYonetimiService enerjiYonetimiService)
        {
            _enerjiYonetimiService = enerjiYonetimiService;
        }

        public IViewComponentResult Invoke()
        {
            var enerjiyonetimilistesi = _enerjiYonetimiService.GetList();
            return View(enerjiyonetimilistesi);
        }
    }
}
