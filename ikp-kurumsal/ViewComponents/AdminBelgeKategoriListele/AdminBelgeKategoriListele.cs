using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.AdminBelgeKategoriListele
{
    public class AdminBelgeKategoriListele : ViewComponent
    {
        private readonly IBelgeKategoriService _belgeKategoriService;

        public AdminBelgeKategoriListele(IBelgeKategoriService belgeKategoriService)
        {
            _belgeKategoriService = belgeKategoriService;
        }

        public IViewComponentResult Invoke()
        {
            var model = _belgeKategoriService.GetList();
            return View(model);
        }
    }
}
