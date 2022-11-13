using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.ArgeGecmisListele
{
    public class ArgeGecmisListele : ViewComponent
    {
        private readonly IArgeGecmisimizService _argeGecmisimizService;

        public ArgeGecmisListele(IArgeGecmisimizService argeGecmisimizService)
        {
            _argeGecmisimizService = argeGecmisimizService;
        }

        public IViewComponentResult Invoke()
        {
            var argeGecmislistesi = _argeGecmisimizService.GetList().OrderBy(x=>x.SiraNo).ToList();
            return View(argeGecmislistesi);
        }
    }
}
