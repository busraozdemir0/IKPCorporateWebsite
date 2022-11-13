using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.BarkodTakipStokListele
{
    public class BarkodTakipStokListele:ViewComponent
    {
        private readonly IBarkodTakipStokService _barkodtakipstokservice;

        public BarkodTakipStokListele(IBarkodTakipStokService barkodtakipstokservice)
        {
            _barkodtakipstokservice = barkodtakipstokservice;
        }

        public IViewComponentResult Invoke()
        {
            var barkodtakipstoklistesi = _barkodtakipstokservice.GetList();
            return View(barkodtakipstoklistesi);
        }
    }
}
