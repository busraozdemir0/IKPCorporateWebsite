using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.isverenbasvurulistele
{
    public class isverendashboardilanlistele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var username = User.Identity.Name;
            var userid = context.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var ilanlarim = context.isilanlaris.Where(x => x.AppUserId == userid).ToList();
            return View(ilanlarim);
        }
    }
}
