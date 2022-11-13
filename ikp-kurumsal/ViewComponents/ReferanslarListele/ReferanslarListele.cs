using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.ReferanslarListele
{
    public class ReferanslarListele:ViewComponent
    {
        private readonly IReferanslarService _referanslarService;

        public ReferanslarListele(IReferanslarService referanslarService)
        {
            _referanslarService = referanslarService;
        }

        public IViewComponentResult Invoke()
        {
            var referanslarlistesi = _referanslarService.GetList();
            return View(referanslarlistesi);
        }
    }
}
