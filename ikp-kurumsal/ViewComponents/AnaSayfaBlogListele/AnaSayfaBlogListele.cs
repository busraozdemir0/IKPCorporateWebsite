using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.AnaSayfaBlogListele
{
    public class AnaSayfaBlogListele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var secilenBlogs = context.blogs.Where(x => x.Blog_status == true).Take(4).ToList();
            return View(secilenBlogs);

        }
    }
}
