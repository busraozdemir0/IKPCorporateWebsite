using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.HeaderSosyalMedya
{
    public class HeaderSosyalMedya : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var list = c.SosyalMedyaLinks.FirstOrDefault();
            ViewBag.FacebookLink = list.FacebookLink.ToString();
            ViewBag.InstagramLink = list.InstagramLink.ToString();
            ViewBag.TwitterLink = list.TwitterLink.ToString();
            return View();
        }
    }
}