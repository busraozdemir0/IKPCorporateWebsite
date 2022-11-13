using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.BlogSayfasiSonBlogs
{
    public class BlogSayfasiSonBlogs:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var secilenBlogs = context.blogs.OrderByDescending(x=>x.Blog_id).Take(4).ToList();
            return View(secilenBlogs);

        }
    }
}
