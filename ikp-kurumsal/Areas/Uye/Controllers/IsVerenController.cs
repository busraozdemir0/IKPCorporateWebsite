using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using ikp_kurumsal.Areas.SY.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.Areas.Uye.Controllers
{
    [Area("Uye")]
    [Authorize(Roles = "isveren")]
    public class IsVerenController : Controller
    {
        private readonly IisilanlariService _isilanlariservice;
        Context c = new Context();

        private readonly UserManager<AppUser> _usermanager;
        private readonly RoleManager<AppRole> _rolemanager;

        public IsVerenController(IisilanlariService isilanlariservice, UserManager<AppUser> usermanager, RoleManager<AppRole> rolemanager)
        {
            _isilanlariservice = isilanlariservice;
            _usermanager = usermanager;
            _rolemanager = rolemanager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            var username = User.Identity.Name;
            var userid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var usernamesurname = c.Users.Where(x => x.UserName == username).Select(y => y.namesurname).FirstOrDefault();
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userSayisi = c.Users.Count().ToString();
            var isilanisayisi = c.isilanlaris.Count().ToString();
            var mesajsayisi = c.iletisimMesajs.Count().ToString();
            var uyeidleri = c.Users.Select(y => y.Id).ToList();
            var isverenler = c.UserRoles.Where(x => x.RoleId == (int)UserRolTypeEnum.IsVeren).Count().ToString();
            var isarayansayisi = c.UserRoles.Where(x => x.RoleId == (int)UserRolTypeEnum.IsArayan).Count().ToString();

            var ilanlarim = c.isilanlaris.Where(x => x.AppUserId == userid).Select(y => y.Id).Count().ToString();

            ViewBag.kullaniciAdi = username;
            ViewBag.adsoyad = usernamesurname;
            ViewBag.mail = usermail;
            ViewBag.uyesayisi = userSayisi;
            ViewBag.ilansayisi = isilanisayisi;
            ViewBag.mesajsayisi = mesajsayisi;
            ViewBag.isverensayisi = isverenler;
            ViewBag.isarayansayisi = isarayansayisi;
            ViewBag.ilansayim = ilanlarim;
            return View();
        }
        public IActionResult Profilim()
        {
            var username = User.Identity.Name;
            var userName = c.Users.Where(x => x.UserName == username).Select(y => y.UserName).FirstOrDefault();
            var name = c.Users.Where(x => x.UserName == username).Select(y => y.namesurname).FirstOrDefault();
            var sifre = c.Users.Where(x => x.UserName == username).Select(y => y.PasswordHash).FirstOrDefault();
            var email = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();

            KullaniciGuncelleDto kullanici = new KullaniciGuncelleDto();
            kullanici.namesurname = name;
            kullanici.username = userName;
            kullanici.email = email;
            kullanici.password = sifre;
            //ViewBag.name = name;
            //ViewBag.sifre = sifre;
            //ViewBag.email = email;
            //ViewBag.userid = userid;
            return View(kullanici);
        }
        [HttpPost]
        public async Task<IActionResult> Profilim(KullaniciGuncelleDto model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
                user.namesurname = model.namesurname;
                user.UserName = model.username;
                user.PasswordHash = _usermanager.PasswordHasher.HashPassword(user, model.password);
                user.Email = model.email;
                IdentityResult result = await _usermanager.UpdateAsync(user);
            }
            return RedirectToAction("Profilim", "IsVeren", new { Areas = "Uye" });

        }
        public IActionResult IsIlaniEkle()
        {
            Context c = new Context();
            var diller = c.dilTablosus.ToList();
            List<SelectListItem> dil = (from i in diller
                                        select new SelectListItem
                                        {
                                            Text = i.DilAdi,
                                            Value = i.Id.ToString()
                                        }).ToList();
            ViewBag.dil = dil;
            return View();
        }
        [HttpPost]
        public IActionResult IsIlaniEkle(isilaniDto isilani)
        {
            var username = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            //var id = c.Users.Where(x => x.namesurname == name).Select(y => y.Id).FirstOrDefault();

            isilani.kisi_id = id;

            isilanlari iss = new isilanlari
            {
                Baslik = isilani.Baslik,
                Aciklama = isilani.Aciklama,
                IsYeriAdres = isilani.IsYeriAdres,
                AppUserId = isilani.kisi_id,
                Status = false

            };
            _isilanlariservice.TAdd(iss);
            return View();
        }
        public IActionResult IsIlaniDuzenle(int id)
        {
            Context c = new Context();
            var diller = c.dilTablosus.ToList();
            List<SelectListItem> dil = (from i in diller
                                        select new SelectListItem
                                        {
                                            Text = i.DilAdi,
                                            Value = i.Id.ToString()
                                        }).ToList();
            ViewBag.dil = dil;
            var duzenlenecek = _isilanlariservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public IActionResult IsIlaniDuzenle(isilaniDto isilani)
        {
            var username = User.Identity.Name;
            var idd = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            //var id = c.Users.Where(x => x.namesurname == name).Select(y => y.Id).FirstOrDefault();

            isilani.kisi_id = idd;

            isilanlari iss = new isilanlari
            {
                Id = isilani.Id,
                Baslik = isilani.Baslik,
                Aciklama = isilani.Aciklama,
                IsYeriAdres = isilani.IsYeriAdres,
                AppUserId = isilani.kisi_id

            };
            if (ModelState.IsValid)
            {
                _isilanlariservice.TUpdate(iss);
                return RedirectToAction("IsIlaniEkle", "IsVeren");
            }
            else
            {
                return View();
            }

        }
        public IActionResult IsIlaniSil(int id)
        {
            var silinecek = _isilanlariservice.TGetById(id);
            _isilanlariservice.TDelete(silinecek);
            return RedirectToAction("IsIlaniEkle", "IsVeren");
        }
        public IActionResult IsBasvuruListele()
        {
            var userIdentity = User.Identity;
            var userName = userIdentity.Name;
           
            var userid = c.Users.Where(x => x.UserName == userName).Select(y => y.Id).FirstOrDefault();
            //var ilanidler = c.isilanlaris.Where(x => x.AppUserId == userid).Select(y => y.Id).ToList();
            //var isbasvurulari = c.IsBasvuruTbls.Where(x => ilanidler.Contains(x.Id)).ToList();
            var ilans = c.isilanlaris.Where(x => x.AppUser.UserName == userName).Include(x => x.IsBasvuruTbls).ThenInclude(y=>y.AppUser).ToList();
            var ilanid = c.isilanlaris.Where(x => x.AppUserId == userid).Select(y => y.Id).ToList();
            var sayi = c.IsBasvuruTbls.Where(x => ilanid.Contains(x.isilanlariId)).Select(y => y.AppUserId).Count();
            //var ilanbasvuru = c.IsBasvuruTbls.Where(x => x.isilanlari.AppUser.Id == userid).Select(y => y.Id).Count().ToString();
            ViewBag.sayi = sayi;

             

            return View(ilans);
        }
      
        public IActionResult IsBasvuruDetay(int id)
        {
            var ilanid = _isilanlariservice.TGetById(id);
            var userName = User.Identity.Name;
            var userid = c.Users.Where(x => x.UserName == userName).Select(y => y.Id).FirstOrDefault();
            //var ilanid = c.isilanlaris.Where(x => x.Id== id).Select(y => y.Id).FirstOrDefault();
           // var ilans = c.isilanlaris.Where(x => x.AppUser.UserName == userName).Include(x => x.IsBasvuruTbls).ThenInclude(y => y.AppUser).ToList();
            return View(ilanid);    
        }
        public IActionResult Isciler()
        {
            Context c = new Context();
            var roleid = _rolemanager.Roles.Where(x => x.Name == "isarayan").Select(y => y.Id).FirstOrDefault();
            var roleidint = Convert.ToInt32(roleid);
            var userid = c.UserRoles.Where(x => x.RoleId == roleidint).Select(y => y.UserId).ToList();
            var kisiler = c.Users.Where(x => userid.Contains(x.Id)).Include(y=>y.isArayanBilgi).ToList();

            
            
            return View(kisiler);
        }        

    }
}
