using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.BlogSayfaKategoriListele
{
    public class BlogSayfaKategoriListele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var blogKategoris = context.blogKategoris.ToList();
            return View(blogKategoris);
        }
    }
}
