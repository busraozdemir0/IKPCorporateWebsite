using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.HakkimizdaMusterilerimizListele
{
    public class HakkimizdaMusterilerimizListele : ViewComponent
    {
        private readonly IMusterilerimizService _Musterilerimizservice;

        public HakkimizdaMusterilerimizListele(IMusterilerimizService Musterilerimizservice)
        {
            _Musterilerimizservice = Musterilerimizservice;
        }

        public IViewComponentResult Invoke()
        {
            var anasayfalistesi = _Musterilerimizservice.GetList();
            return View(anasayfalistesi);
        }
    }
}