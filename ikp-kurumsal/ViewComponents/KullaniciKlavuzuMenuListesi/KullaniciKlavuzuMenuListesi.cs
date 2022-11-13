using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.KullaniciKlavuzuMenuListesi
{
    public class KullaniciKlavuzuMenuListesi:ViewComponent
    {
        private readonly IMenuService _menuservice;

        public KullaniciKlavuzuMenuListesi(IMenuService menuservice)
        {
            _menuservice = menuservice;
        }

        public IViewComponentResult Invoke()
        {
            var menuler = _menuservice.GetList();
            return View(menuler);
        }
    }
}
