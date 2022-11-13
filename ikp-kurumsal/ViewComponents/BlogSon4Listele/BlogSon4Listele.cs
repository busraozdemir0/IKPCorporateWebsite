using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.BlogSon4Listele
{
    public class BlogSon4Listele: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var blog = c.blogKategoris.ToList();
            return View(blog);
        }
    }
}
