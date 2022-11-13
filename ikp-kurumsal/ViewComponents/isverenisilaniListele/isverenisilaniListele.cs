using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.isverenisilaniListele
{
    public class isverenisilaniListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var username = User.Identity.Name;
            var user_id = context.Users.Where(x=>x.UserName==username).Select(y=>y.Id).FirstOrDefault();
            var is_ilanlari = context.isilanlaris.Where(x=>x.AppUserId==user_id).ToList();

            return View(is_ilanlari);
        }
    }
}
