using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.iletisimbilgileri
{
    public class iletisimbilgileri:ViewComponent
    {
        private readonly IiletisimService _iletisimService;

        public iletisimbilgileri(IiletisimService iletisimService)
        {
            _iletisimService = iletisimService;
        }

        public IViewComponentResult Invoke()
        {
            var iletisimbilgileri = _iletisimService.GetList();
            return View(iletisimbilgileri);
        }
    }
}
