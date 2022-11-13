using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.BlogKategoriListele
{
    public class BlogKategoriListele:ViewComponent
    {
        private readonly IBlogKategoriService _blogkategoriService;

        public BlogKategoriListele(IBlogKategoriService blogkategoriService)
        {
            _blogkategoriService = blogkategoriService;
        }

        public IViewComponentResult Invoke()
        {
            var kategorilistesi = _blogkategoriService.GetList();
            return View(kategorilistesi);
        }
    }
}
