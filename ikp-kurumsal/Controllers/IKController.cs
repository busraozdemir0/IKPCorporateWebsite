using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using ikp_kurumsal.Areas.SY.Models;
using ikp_kurumsal.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.Controllers
{


    public class IKController : Controller
    {

        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;

        IsilanlariManager isilanlarimanager = new IsilanlariManager(new EfIsilanlariRepository());

        public IKController(UserManager<AppUser> usermanager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _usermanager = usermanager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            Context c = new Context();
            var isveren = c.UserRoles.Where(x => x.RoleId == (int)UserRolTypeEnum.IsVeren).Count().ToString();
            var isarayan = c.UserRoles.Where(x => x.RoleId == (int)UserRolTypeEnum.IsArayan).Count().ToString();
            var isilanisayisi = c.isilanlaris.Count();
            ViewBag.isilaniSayisi = isilanisayisi;
            ViewBag.isarayanSayisi = isarayan;
            ViewBag.kulaniciSayisi = c.Users.Count();
            ViewBag.isverenSayisi = isveren;
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
                        //return RedirectToAction("CVYukle", "IsArayan", new { Areas = "Uye" });
                        return RedirectToRoute(new { action = "CVYukle", controller = "IsArayan", area = "Uye" });
                    }
                    else if (roleType == (int)UserRolTypeEnum.IsVeren)
                    {
                        //Response.Redirect("/Uye/IsVeren/Dashboard", true);
                        //return RedirectToAction("Dashboard", "IsVeren", new { Areas = "Uye" });
                        return RedirectToRoute(new { action = "Dashboard", controller = "IsVeren", area = "Uye" });

                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Giriş yetkiniz bulunmamaktadır.";
                        return View();
                    }

                }
                else
                {
                    ViewBag.ErrorMessage = "Lütfen tüm alanları eksiksiz doldurunuz.";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Giriş bilgileri hatalı.";
                return View();
            }
        }
        public IActionResult isDetay(int id)
        {

            var is_detay = isilanlarimanager.TGetById(id);
            return View(is_detay);
        }


        public IActionResult BasvuruYap(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var ilanid = id;
                Context context = new Context();
                var username = User.Identity.Name;
                var userid = context.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
                IsBasvuruTbl isBasvuruTbl = new IsBasvuruTbl
                {
                    isilanlariId = ilanid,
                    AppUserId = userid
                };
                context.IsBasvuruTbls.Add(isBasvuruTbl);
                context.SaveChanges();
                return RedirectToAction("Index", "IK");

            }
            else
            {
                return RedirectToAction("Index", "IK");
                
                if (User.Identity.IsAuthenticated)
                {
                    return RedirectToAction("isDetay", "IK");
                }
                else
                {
                    return View();
                }
            }



        }
        public IActionResult IkLoginForm()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> IkLoginForm()
        //{

        //}

        public IActionResult SifremiUnuttum()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SifremiUnuttum(SifremiUnuttum Sifre)
        {
            Context c = new Context();
            var kisimail = c.Users.Where(x => x.Email == Sifre.Mail).Select(y => y.Email).FirstOrDefault();
            var kisiId = c.Users.Where(x => x.Email == kisimail).Select(y => y.Id).FirstOrDefault();

            var kontrol = c.sifremiUnuttums.Where(x => kisimail.Contains(x.Mail)).FirstOrDefault();
            if (kontrol!=null)
            {

                var kisi = c.sifremiUnuttums.Where(x => x.Mail == kisimail).Select(y => y.Id).FirstOrDefault();
                var person = c.sifremiUnuttums.Find(kisi);
                c.sifremiUnuttums.Remove(person);
                c.SaveChanges();
                Random rand = new Random();
                var sayi1 = rand.Next(1000, 9999);
                Sifre.RandomKod = sayi1.ToString();
                Sifre.Tarih = DateTime.Now;
                Sifre.AppUserId = kisiId;
                c.sifremiUnuttums.Add(Sifre);
                c.SaveChanges();
            }
            else
            {
                Random random = new Random();
                var sayi = random.Next(1000, 9999);
                Sifre.RandomKod = sayi.ToString();
                Sifre.Tarih = DateTime.Now;
                Sifre.AppUserId = kisiId;
                c.sifremiUnuttums.Add(Sifre);
                c.SaveChanges();

            }


            if (kisimail == Sifre.Mail)
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("swggerx@gmail.com"));
                email.To.Add(MailboxAddress.Parse(kisimail));
                email.Subject = "Onay Kodu";
                email.Body = new TextPart(TextFormat.Plain) { Text = Sifre.RandomKod };

                // send email
                using var smtp = new SmtpClient();
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("swggerx@gmail.com", "tltmlfchqcjelvtx");
                smtp.Send(email);
                smtp.Disconnect(true);
            }
            SifremiUnuttumMailTut tut = new SifremiUnuttumMailTut();
            tut.Mail = Sifre.Mail;
            tut.SifremiUnuttumId = Sifre.Id;
            c.sifremiUnuttumMailTuts.Add(tut);
            c.SaveChanges();
            HttpContext.Session.SetString("Mail", kisimail);
            return RedirectToAction("OnayKodu", "IK");
        }
        public IActionResult OnayKodu(int id)
        {

            return View();
        }
        [HttpPost]
        public IActionResult OnayKodu(OnayKoduDto onay)
        {
            Context c = new Context();
            var kod = onay.OnayKodu;
            var kisiOnayeslesme = c.sifremiUnuttums.Where(x => kod.Contains(x.RandomKod)).FirstOrDefault().ToString();
            if (true)
            {
                return RedirectToAction("YeniSifre", "IK");
            }
            else
            {
                return View();
            }

        }
        public IActionResult YeniSifre()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> YeniSifre(YeniSifreDto dto)
        {
            Context c = new Context();

            var mail = HttpContext.Session.GetString("Mail");
            var username = c.Users.Where(x => x.Email == mail).Select(y => y.UserName).FirstOrDefault();
            AppUser kisi = await _usermanager.FindByNameAsync(username);

            if(dto.Sifre == dto.SifreYeniden)
            {
                kisi.PasswordHash = _usermanager.PasswordHasher.HashPassword(kisi, dto.Sifre);
                IdentityResult result = await _usermanager.UpdateAsync(kisi);
                return RedirectToRoute(new { action = "Index", controller = "Giris", area = "Uye" });
                //return RedirectToAction("Index", "Giris", new { Areas="Uye" });
            }
            else
            {
                ViewBag.HataMesaji = "Şifreler Uyuşmuyor";
                return View();
            }
          


            
         }


    }

}
