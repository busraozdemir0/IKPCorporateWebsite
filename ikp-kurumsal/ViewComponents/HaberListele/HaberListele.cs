using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.HaberListele
{
    public class HaberListele:ViewComponent
    {
        private readonly IHaberService _haberService;

        public HaberListele(IHaberService haberService)
        {
            _haberService = haberService;
        }

        public IViewComponentResult Invoke()
        {
            var haberlistesi = _haberService.GetList();
            return View(haberlistesi);
        }
    }
}
