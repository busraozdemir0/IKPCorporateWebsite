using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.BlogOneCikanlar
{
    public class BlogOneCikanlar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var onecikanBlogs = context.blogs.Where(x => x.Blog_status == true).Take(5).ToList();
            return View(onecikanBlogs);

        }
    }
}
