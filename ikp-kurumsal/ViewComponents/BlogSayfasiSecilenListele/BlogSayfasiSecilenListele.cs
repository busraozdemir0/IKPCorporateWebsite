using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.BlogSayfasiSecilenListele
{
    public class BlogSayfasiSecilenListele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var secilenBlogs = context.blogs.Where(x => x.Blog_status == true).Take(4).ToList();
            return View(secilenBlogs);

        }
    }
}
