using Castle.Core.Smtp;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using ikp_kurumsal.Areas.SY.Models;
using ikp_kurumsal.Areas.Uye.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace ikp_kurumsal.Areas.Uye.Controllers
{
    [Area("Uye")]
    public class GirisController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public GirisController(SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(KullaniciGirisDto girisbilgileri)
        {
            
            Context context = new Context();
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(girisbilgileri.username, girisbilgileri.password, false, true);

                if (result.Succeeded)
                {
                    var name = context.Users.Where(x => x.UserName == girisbilgileri.username).Select(y => y.namesurname).FirstOrDefault();
                    var userid = context.Users.Where(x => x.namesurname == name).Select(y => y.Id).FirstOrDefault();

                    var UserRole = context.UserRoles.Where(x => x.UserId == userid).FirstOrDefault();
                    var roleType = context.Roles.Where(x => x.Id == UserRole.RoleId).Select(y => y.RolType).FirstOrDefault();

                    if (roleType == (int)UserRolTypeEnum.IsArayan)
                    {
                        return RedirectToAction("CVYukle", "IsArayan", new { Areas = "Uye" });
                    }
                    else if (roleType == (int)UserRolTypeEnum.IsVeren)
                    {
                        return RedirectToAction("Dashboard", "IsVeren", new { Areas = "Uye" });
                    }
                    else
                    {
                        return View();
                    }

                }
                else
                {
                    return RedirectToAction("Index", "Giris", new { Areas = "Uye" });
                }
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Giris");
        }
     

    }
}
