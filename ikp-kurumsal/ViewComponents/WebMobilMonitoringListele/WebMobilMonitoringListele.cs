using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.WebMobilMonitoringListele
{
    public class WebMobilMonitoringListele:ViewComponent
    {
        private readonly IWebMobilService _webMobilService;

        public WebMobilMonitoringListele(IWebMobilService webMobilService)
        {
            _webMobilService = webMobilService;
        }

        public IViewComponentResult Invoke()
        {
            var webmobillistesi = _webMobilService.GetList();
            return View(webmobillistesi);
        }
    }
}
