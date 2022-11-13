using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.HakkimizdaGuncelBilgiListele
{
    public class HakkimizdaGuncelBilgiListele:ViewComponent
    {
        private readonly IHakkimizdaGuncelBilgiService _hakkimizdaGuncelBilgiService;

        public HakkimizdaGuncelBilgiListele(IHakkimizdaGuncelBilgiService hakkimizdaGuncelBilgiService)
        {
            _hakkimizdaGuncelBilgiService = hakkimizdaGuncelBilgiService;
        }

        public IViewComponentResult Invoke()
        {
            var guncelbilgi = _hakkimizdaGuncelBilgiService.GetList();
            return View(guncelbilgi);
        }
    }
}
