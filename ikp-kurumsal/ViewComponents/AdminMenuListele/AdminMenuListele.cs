using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.AdminMenüListele
{
    public class AdminMenuListele:ViewComponent
    {
        private readonly IMenuService _menuservice;

        public AdminMenuListele(IMenuService menuservice)
        {
            _menuservice = menuservice;
        }

        public IViewComponentResult Invoke()
        {
            var menuler = _menuservice.GetList();
            return View(menuler);

        }
    }
}
