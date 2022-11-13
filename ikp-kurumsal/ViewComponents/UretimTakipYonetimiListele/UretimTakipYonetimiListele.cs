using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.UretimTakipYonetimiListele
{
    public class UretimTakipYonetimiListele:ViewComponent
    {
        private readonly IUretimTakipYonetimiService _uretimTakipYonetimiService;

        public UretimTakipYonetimiListele(IUretimTakipYonetimiService uretimTakipYonetimiService)
        {
            _uretimTakipYonetimiService = uretimTakipYonetimiService;
        }

        public IViewComponentResult Invoke()
        {
            var uretimtakiplistesi = _uretimTakipYonetimiService.GetList();
            return View(uretimtakiplistesi);
        }
    }
}
