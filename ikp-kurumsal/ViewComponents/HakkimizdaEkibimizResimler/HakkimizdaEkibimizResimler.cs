using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.HakkimizdaEkibimizResimler
{
    public class HakkimizdaEkibimizResimler:ViewComponent
    {
        private readonly IHakkimizdaService _hakkimizdaService;

        public HakkimizdaEkibimizResimler(IHakkimizdaService hakkimizdaService)
        {
            _hakkimizdaService = hakkimizdaService;
        }

        public IViewComponentResult Invoke()
        {
            var resimler = _hakkimizdaService.GetList();
            return View(resimler);
        }
    }
}
