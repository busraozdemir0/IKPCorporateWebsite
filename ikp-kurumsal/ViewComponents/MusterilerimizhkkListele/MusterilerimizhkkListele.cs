using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.MusterilerimizhkkListele
{
    public class MusterilerimizhkkListele : ViewComponent
    {
        private readonly IMusterilerimizService _musterilerimizService;

        public MusterilerimizhkkListele(IMusterilerimizService musterilerimizService)
        {
            _musterilerimizService = musterilerimizService;
        }

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var list = c.Musterilerimizs.FirstOrDefault();
            ViewBag.baslik = list.MusterilerimizBaslik.ToString();
            ViewBag.icerik = list.Musterilerimizİcerik.ToString();
            var musterilerimizlistesi = _musterilerimizService.GetList().Where(x => x.MusterilerimizYol != null).ToList();
            return View(musterilerimizlistesi);
        }
    }
}