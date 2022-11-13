using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using ikp_kurumsal.Areas.SY.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.Areas.Uye.Controllers
{
    [Area("Uye")]
    [Authorize(Roles ="isarayan")]
    public class IsArayanController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IisarayanBilgiService _isarayanBilgiservice;
        Context context = new Context();

        public IsArayanController(IWebHostEnvironment webHost, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IisarayanBilgiService isarayanBilgiservice)
        {
            _webHost = webHost;
            _userManager = userManager;
            _roleManager = roleManager;
            _isarayanBilgiservice = isarayanBilgiservice;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profilim()
        {
            var username = User.Identity.Name;
            var userName = context.Users.Where(x => x.UserName == username).Select(y => y.UserName).FirstOrDefault();
            var name = context.Users.Where(x => x.UserName == username).Select(y => y.namesurname).FirstOrDefault();
            var sifre = context.Users.Where(x => x.UserName == username).Select(y => y.PasswordHash).FirstOrDefault();
            var email = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userid = context.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var cvyol = context.isArayanBilgis.Where(x => x.AppUserId == userid).Select(y => y.Cv_Yol).FirstOrDefault();

            KullaniciGuncelleDto kullanici = new KullaniciGuncelleDto();
            kullanici.namesurname = name;
            kullanici.username = userName;
            kullanici.email = email;
            kullanici.password = sifre;
            kullanici.isarayancvyol = cvyol;

            ViewBag.namesurname = name;
            //ViewBag.name = name;
            //ViewBag.sifre = sifre;
            //ViewBag.email = email;
            //ViewBag.userid = userid;
            return View(kullanici);
        }
        [HttpPost]
        public async Task<IActionResult> Profilim(KullaniciGuncelleDto model)
        {
            var username = User.Identity.Name;

            KullaniciGuncelleDto kullanici = new KullaniciGuncelleDto();
            var nameSurname = context.Users.Where(x => x.UserName == username).Select(y => y.namesurname).FirstOrDefault();

            ViewBag.adsoyad = nameSurname;
            var userid = context.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var cvid = context.isArayanBilgis.Where(x => x.AppUserId == userid).Select(y => y.Id).FirstOrDefault();
            model.userId = userid;

            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.namesurname = model.namesurname;
                user.UserName = model.username;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,model.password);
                user.Email = model.email;
                IdentityResult result = await _userManager.UpdateAsync(user);
            }
            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(model.isarayancv.FileName);
            string extension = Path.GetExtension(model.isarayancv.FileName);
            model.isarayancvyol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/IsArayanCv/", filename);
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await model.isarayancv.CopyToAsync(filestream);
            }
            isArayanBilgi isArayan = new isArayanBilgi
            {
                Id = cvid,
                AppUserId = model.userId,
                Cv = model.isarayancv,
                Cv_Yol = model.isarayancvyol
            };
            _isarayanBilgiservice.TUpdate(isArayan);
            return RedirectToAction("Profilim","IsArayan",new { Areas="Uye"});

        }

        public IActionResult CvYukle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CVYukle(isarayanBilgiDto isarayanbilgidto)
        {
            if(ModelState.IsValid)
            {
                var username = User.Identity.Name;
                var nameSurname = context.Users.Where(x => x.UserName == username).Select(y => y.namesurname).FirstOrDefault();

                ViewBag.adsoyad = nameSurname;
                var userid = context.Users.Where(x=>x.UserName==username).Select(y=>y.Id).FirstOrDefault();
                isarayanbilgidto.IsArayanId = userid;

                string wwwRootPath = _webHost.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(isarayanbilgidto.IsArayanCv.FileName);
                string extension = Path.GetExtension(isarayanbilgidto.IsArayanCv.FileName);
                isarayanbilgidto.IsArayanCvYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/IsArayanCv/", filename);
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await isarayanbilgidto.IsArayanCv.CopyToAsync(filestream);
                }
                isArayanBilgi isarayanbilgi = new isArayanBilgi
                {
                    AppUserId = isarayanbilgidto.IsArayanId,
                    Cv = isarayanbilgidto.IsArayanCv,
                    Cv_Yol = isarayanbilgidto.IsArayanCvYol

                };
                _isarayanBilgiservice.TAdd(isarayanbilgi);
                return RedirectToAction("Profilim", "IsArayan");
            }
            else
            {
                return View();

            }
        }
        //public IActionResult DashBoard()
        //{
        //    var userName = User.Identity.Name;
        //    var nameSurname = context.Users.Where(x => x.UserName == userName).Select(y => y.namesurname).FirstOrDefault();
        //    var userId = context.Users.Where(x => x.UserName == userName).Select(y => y.Id).FirstOrDefault();
        //    var ilanSayisi = context.isilanlaris.Count().ToString();
        //    var basvurdugumIlanSayisi = context.IsBasvuruTbls.Where(x => x.AppUserId == userId).Count().ToString();


        //    ViewBag.adsoyad = nameSurname;
        //    ViewBag.isilansayisi = ilanSayisi;
        //    ViewBag.basvurdugumilans = basvurdugumIlanSayisi;
        //    return View();
        //}
        public IActionResult BasvurduguIlanlar()
        {
            var userName = User.Identity.Name;
            var userId = context.Users.Where(x => x.UserName == userName).Select(y => y.Id).FirstOrDefault(); 
            
            var basvurulanIlans = context.IsBasvuruTbls.Where(x => x.AppUserId == userId).Select(y => y.isilanlariId).ToList();
            var basvurular = context.isilanlaris.Where(x => basvurulanIlans.Contains(x.Id)).Select(y => y.Baslik).ToList();

            //var basvurulars = context.IsBasvuruTbls.Where(x => x.AppUserId == userId).Include(x => x.isilanlari).ToList();
            var basvurulars = context.IsBasvuruTbls.Where(x => x.AppUserId == userId).Select(y => y.Id).ToList();
            var bas = context.isilanlaris.Where(x => basvurulars.Contains(x.Id)).ToList();

            return View(bas);

        }
    }
}
