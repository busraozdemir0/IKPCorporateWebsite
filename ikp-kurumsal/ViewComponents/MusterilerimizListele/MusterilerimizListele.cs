using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.MusterilerimizListele
{
    public class MusterilerimizListele : ViewComponent
    {
        private readonly IMusterilerimizService _musterilerimizService;

        public MusterilerimizListele(IMusterilerimizService musterilerimizService)
        {
            _musterilerimizService = musterilerimizService;
        }

        public IViewComponentResult Invoke()
        {
            var musterilerimizlistele = _musterilerimizService.GetList();
            return View(musterilerimizlistele);
        }
    }
}