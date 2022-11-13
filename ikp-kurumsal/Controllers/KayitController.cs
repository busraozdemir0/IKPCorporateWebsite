using EntityLayer.Concrete;
using EntityLayer.Enums;
using ikp_kurumsal.Areas.SY.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.Controllers
{
    public class KayitController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly RoleManager<AppRole> _rolemanager;

        public KayitController(UserManager<AppUser> usermanager, RoleManager<AppRole> rolemanager)
        {
            _usermanager = usermanager;
            _rolemanager = rolemanager;
        }
        public IActionResult Index()
        {


            Context c = new Context();
            var rollistesi = c.Roles.Where(x => x.RolType != ((int)UserRolTypeEnum.Admin)).ToList();

            List<SelectListItem> roller = (from x in rollistesi
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }).ToList();

            ViewBag.roller = roller;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(KullaniciKayitDto kayit)
        {
            Context c = new Context();
            var rollistesi = c.Roles.Where(x => x.RolType != ((int)UserRolTypeEnum.Admin)).ToList();

            List<SelectListItem> roller = (from x in rollistesi
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }).ToList();

            ViewBag.roller = roller;

            if (ModelState.IsValid)
            {
                if (kayit.confirmpassword == kayit.password)
                {

                 

                    var rolename = c.Roles.Find(kayit.RolId);
                    var rolename1 = rolename.ToString();

                    AppUser user = new AppUser()
                    {
                        Email = kayit.mail,
                        UserName = kayit.username,
                        namesurname = kayit.namesurname,

                    };
                    var result = await _usermanager.CreateAsync(user, kayit.password);
                    if(result.Succeeded)
                    {
                        var defaultrole = rolename1;
                        if (defaultrole != null)
                        {
                            IdentityResult roleresult = await _usermanager.AddToRoleAsync(user, defaultrole);
                        }
                    }
                    return View();
                }
                else
                {
                    ViewBag.hatamesaji = "Şifreler Uyuşmuyor";
                    return View();
                }



            }
            else
            {
                ViewBag.hatamesaji = "Şifreler Uyuşmuyor";
                return View();
            }

        }
    }
}
