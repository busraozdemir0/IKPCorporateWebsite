using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.HakkimizdaResimler
{
    public class HakkimizdaResimler:ViewComponent
    {
        private readonly IHakkimizdaService _hakkimizdaService;

        public HakkimizdaResimler(IHakkimizdaService hakkimizdaService)
        {
            _hakkimizdaService = hakkimizdaService;
        }

        public IViewComponentResult Invoke()
        {
            var hakkimizdaresimler = _hakkimizdaService.GetList();
            return View(hakkimizdaresimler);
        }
    }
}
