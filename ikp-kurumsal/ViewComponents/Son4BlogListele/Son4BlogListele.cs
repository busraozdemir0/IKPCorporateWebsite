using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.Son4BlogListele
{
    public class Son4BlogListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var sondortblog = context.blogs.TakeLast(4).ToList();
            return View(sondortblog);
        }
    }
}
