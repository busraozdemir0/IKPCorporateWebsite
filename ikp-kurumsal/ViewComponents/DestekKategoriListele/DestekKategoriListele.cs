using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.DestekKategoriListele
{
    public class DestekKategoriListele: ViewComponent
    {
        private readonly IDestekPortaliKategoriService _destekkategoriservice;

        public DestekKategoriListele(IDestekPortaliKategoriService destekkategoriservice)
        {
            _destekkategoriservice = destekkategoriservice;
        }

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var destekkategorilistesi = _destekkategoriservice.GetList();
            return View(destekkategorilistesi);
        }
    }
}
