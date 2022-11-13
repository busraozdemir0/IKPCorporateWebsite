using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.AnaSayfaPortfolyoListele
{
    public class AnaSayfaPortfolyoListele : ViewComponent
    {
        private readonly IReferanslarService _referanslarService;

        public AnaSayfaPortfolyoListele(IReferanslarService referanslarService)
        {
            _referanslarService = referanslarService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _referanslarService.GetAnaReferansList();
            return View(list);
        }
    }
}