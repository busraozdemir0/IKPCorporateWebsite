using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using ikp_kurumsal.Models;
using ikp_kurumsal.ViewComponents.BlogKategoriListele;
using ikp_kurumsal.ViewComponents.BlogSon4Listele;
using ikp_kurumsal.ViewComponents.EgitimVideoIlgiliVideolar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SmartBreadcrumbs.Attributes;
using SmartBreadcrumbs.Nodes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.Controllers
{
    [DefaultBreadcrumb]
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IEnerjiYonetimiService _enerjiyonetimiservice;
        private readonly ISurumKilavuzuService _surumklavuzuservice;
        private readonly IHakkimizdaService _hakkimizdaservice;
        private readonly IKariyerService _kariyerservice;
        private readonly IBelgelerService _belgelerservice;
        private readonly IiletisimService _iletisimservice;
        private readonly IiletisimMesajService _iletisimMesajservice;
        private readonly IUretimTakipYonetimiService _urettakipyonetimiservice;
        private readonly IBakimYonetimiService _Bakimyonetimiservice;
        private readonly IKaliteYonetimiService _KaliteYonetimiservice;
        private readonly IBarkodTakipStokService _Barkodtakipservice;
        private readonly IWebMobilService _webmobileservice;
        private readonly IEntegreSistemService _Entegresistemservice;
        private readonly IEndustriAkilliFabrikaService _Endustriakillifabrikaservice;
        private readonly IReferanslarService _referanslarservice;
        private readonly IHaberService _haberservice;
        private readonly IBlogService _blogservice;
        private readonly IBlogKategoriService _blogkategoriservice;
        private readonly IDestekPortaliService _Destekportaliservice;
        private readonly IArgeService _argeservice;
        private readonly IEgitimVideolariService _egitimvideolariservice;
        private readonly ISurumKilavuzIcerikService _surumklavuzuicerikservice;
        private readonly IAltBilgiService _altBilgiService;
        private readonly IVideoKategoriService _videokategoriservice;
        private readonly IDestekPortaliKategoriService _destekportalikategoriservice;
        private readonly ILogger<HomeController> _logger;
        private readonly IKullaniciKlavuzuIcerikService _kullaniciKlavuzuIcerikService;

        public HomeController(IEnerjiYonetimiService enerjiyonetimiservice, ISurumKilavuzuService surumklavuzuservice, IHakkimizdaService hakkimizdaservice, IKariyerService kariyerservice, IBelgelerService belgelerservice, IiletisimService iletisimservice, IiletisimMesajService iletisimMesajservice, IUretimTakipYonetimiService urettakipyonetimiservice, IBakimYonetimiService bakimyonetimiservice, IKaliteYonetimiService kaliteYonetimiservice, IBarkodTakipStokService barkodtakipservice, IWebMobilService webmobileservice, IEntegreSistemService entegresistemservice, IEndustriAkilliFabrikaService endustriakillifabrikaservice, IReferanslarService referanslarservice, IHaberService haberservice, IBlogService blogservice, IBlogKategoriService blogkategoriservice, IDestekPortaliService destekportaliservice, IArgeService argeservice, IEgitimVideolariService egitimvideolariservice, ISurumKilavuzIcerikService surumklavuzuicerikservice, IAltBilgiService altBilgiService, IVideoKategoriService videokategoriservice, IDestekPortaliKategoriService destekportalikategoriservice, ILogger<HomeController> logger, IKullaniciKlavuzuIcerikService kullaniciKlavuzuIcerikService)
        {
            _enerjiyonetimiservice = enerjiyonetimiservice;
            _surumklavuzuservice = surumklavuzuservice;
            _hakkimizdaservice = hakkimizdaservice;
            _kariyerservice = kariyerservice;
            _belgelerservice = belgelerservice;
            _iletisimservice = iletisimservice;
            _iletisimMesajservice = iletisimMesajservice;
            _urettakipyonetimiservice = urettakipyonetimiservice;
            _Bakimyonetimiservice = bakimyonetimiservice;
            _KaliteYonetimiservice = kaliteYonetimiservice;
            _Barkodtakipservice = barkodtakipservice;
            _webmobileservice = webmobileservice;
            _Entegresistemservice = entegresistemservice;
            _Endustriakillifabrikaservice = endustriakillifabrikaservice;
            _referanslarservice = referanslarservice;
            _haberservice = haberservice;
            _blogservice = blogservice;
            _blogkategoriservice = blogkategoriservice;
            _Destekportaliservice = destekportaliservice;
            _argeservice = argeservice;
            _egitimvideolariservice = egitimvideolariservice;
            _surumklavuzuicerikservice = surumklavuzuicerikservice;
            _altBilgiService = altBilgiService;
            _videokategoriservice = videokategoriservice;
            _destekportalikategoriservice = destekportalikategoriservice;
            _logger = logger;
            _kullaniciKlavuzuIcerikService = kullaniciKlavuzuIcerikService;
        }


        [HttpPost]
        public IActionResult DilSessionId(int id)
        {
            HttpContext.Session.SetInt32("DilId", id);

            return Ok();

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SurumKilavuzu()
        {

            Context c = new Context();

            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));

            if (dilId == 0)
            {
                var surumklavuzu = c.surumKilavuzus.Where(x => x.DilTablosuId == 1).FirstOrDefault();
                ViewBag.baslik = surumklavuzu.SurumKilavuz_Baslik.ToString();
                var surumkilavuzu = _surumklavuzuservice.GetList(dilId = 1);
                return View(surumkilavuzu);
            }
            else
            {
                var surumklavuzu = c.surumKilavuzus.Where(x => x.DilTablosuId == dilId).FirstOrDefault();
                ViewBag.baslik = surumklavuzu.SurumKilavuz_Baslik.ToString();
                var surumkilavuzu = _argeservice.GetList(dilId);
                return View(surumkilavuzu);
            }
            //var surumkilavuzu = _surumklavuzuservice.GetList();
            //return View(surumkilavuzu);
        }
        public IActionResult SurumKilavuzuDetay(int id)
        {
            Context c = new Context();
            var surumkilavuzu = c.surumKilavuzus.FirstOrDefault();
            ViewBag.baslik = surumkilavuzu.SurumKilavuz_Baslik.ToString();
            var surumbaslik = c.surumKilavuzus.Where(x => x.SurumKilavuz_Id == id).Select(y => y.SurumKilavuz_Aciklama).FirstOrDefault();
            ViewBag.surumKilavuzBaslik = surumbaslik;
            var surumdetay = c.surumKilavuzIceriks.Where(x => x.SurumKilavuzuSurumKilavuz_Id == id).Include(y => y.SurumKilavuzu).ToList();

            return View(surumdetay);
        }
        public IActionResult Hakkimizda()
        {
            Context c = new Context();
            var user = User.Identity.Name;
            var kullanici = c.Users.Count();
            var isveren = c.UserRoles.Where(x => x.RoleId == (int)UserRolTypeEnum.IsVeren).Count().ToString();
            var isarayan = c.UserRoles.Where(x => x.RoleId == (int)UserRolTypeEnum.IsArayan).Count().ToString();
            var isilani = c.isilanlaris.Count().ToString();

            ViewBag.kulaniciSayisi = kullanici;
            ViewBag.isverenSayisi = isveren;
            ViewBag.isarayanSayisi = isarayan;
            ViewBag.isilaniSayisi = isilani;

            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            var anaHakkimizda = new Hakkimizda();
            if (dilId == 0)
            {
                var hakkimizda = _hakkimizdaservice.GetList(dilId = 1);
                if (hakkimizda.Count > 0)
                {
                    anaHakkimizda = hakkimizda[0];
                }
            }
            else
            {
                var hakkimizda = _hakkimizdaservice.GetList(dilId);
                if (hakkimizda.Count > 0)
                {
                    anaHakkimizda = hakkimizda[0];
                }
            }

            return View(anaHakkimizda);
        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult Kariyer()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var kariyer = _kariyerservice.GetList(dilId = 1);
                return View(kariyer);
            }
            else
            {
                var kariyer = _kariyerservice.GetList(dilId);
                return View(kariyer);
            }
        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult KariyerDetay(int id)
        {
            var kariyerdetay = _kariyerservice.TGetById(id);
            return View(kariyerdetay);
        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult Belgelerimiz()
        {
            List<Belgeler> belgelers;
            using (Context context = new Context())
            {
                belgelers = context.belgelers.Include(x => x.BelgeKategori).ToList();
            }

            return View(belgelers);
        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult Arge()
        {
            Arge argeItems = new Arge();

            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var argelist = _argeservice.GetList(dilId = 1);

                if (argelist != null)
                {
                    argeItems = argelist[0];
                }

            }
            else
            {
                var argelist = _argeservice.GetList(dilId);
                if (argelist != null)
                {
                    argeItems = argelist[0];
                }

            }

            ViewBag.ArgeGecmisimiz = new Context().argeGecmisimizs.ToList();

            return View(argeItems);

        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult UretimTakipYonetimi()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var uretim = _urettakipyonetimiservice.GetList(dilId = 1);
                return View(uretim);
            }
            else
            {
                var uretim = _urettakipyonetimiservice.GetList(dilId);
                return View(uretim);
            }

        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult UretimTakipYonetimiDetay(int id)
        {
            var uretimtakiplistdetay = _urettakipyonetimiservice.TGetById(id);

            return View(uretimtakiplistdetay);

        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult Iletisim()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Iletisim(iletisimMesaj mesaj)
        {
            if (ModelState.IsValid)
            {
                _iletisimMesajservice.TAdd(mesaj);
                return RedirectToAction("Iletisim", "Home");
            }
            else
            {
                return View();
            }

        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult BakimYonetimi()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var bakim = _Bakimyonetimiservice.GetList(dilId = 1);
                return View(bakim);
            }
            else
            {
                var bakim = _Bakimyonetimiservice.GetList(dilId);
                return View(bakim);
            }

        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult BakimYonetimiDetay(int id)
        {
            var bakimyonetimidetay = _Bakimyonetimiservice.TGetById(id);
            return View(bakimyonetimidetay);

        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult EnerjiYonetimi()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var enerji = _enerjiyonetimiservice.GetList(dilId = 1);
                return View(enerji);
            }
            else
            {
                var enerji = _enerjiyonetimiservice.GetList(dilId);
                return View(enerji);
            }

        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult EnerjiYonetimiDetay(int id)
        {
            var enerji = _enerjiyonetimiservice.TGetById(id);
            return View(enerji);
        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult KaliteYonetimi()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var kalite = _KaliteYonetimiservice.GetList(dilId = 1);
                return View(kalite);
            }
            else
            {
                var kalite = _KaliteYonetimiservice.GetList(dilId);
                return View(kalite);
            }

        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult KaliteYonetimiDetay(int id)
        {
            var kalite = _KaliteYonetimiservice.TGetById(id);
            return View(kalite);
        }
        [Breadcrumb("ViewData.Title")]
        public IActionResult BarkodTakipliStokYonetimi()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var barkod = _Barkodtakipservice.GetList(dilId = 1);
                return View(barkod);
            }
            else
            {
                var barkod = _Barkodtakipservice.GetList(dilId);
                return View(barkod);
            }

        }
        public IActionResult BarkodTakipliStokDetay(int id)
        {
            var barkodtakip = _Barkodtakipservice.TGetById(id);
            return View(barkodtakip);
        }
        public IActionResult WebMobilMonitoring()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var web = _webmobileservice.GetList(dilId = 1);
                return View(web);
            }
            else
            {
                var web = _webmobileservice.GetList(dilId);
                return View(web);
            }

        }
        public IActionResult WebMobileDetay(int id)
        {
            var webmobiledetay = _webmobileservice.TGetById(id);
            return View(webmobiledetay);
        }
        public IActionResult EntegreSistemler()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var entegre = _Entegresistemservice.GetList(dilId = 1);
                return View(entegre);
            }
            else
            {
                var entegre = _Entegresistemservice.GetList(dilId);
                return View(entegre);
            }

        }
        public IActionResult EntegreDetay(int id)
        {
            var entegredetay = _Entegresistemservice.TGetById(id);
            return View(entegredetay);
        }
        public IActionResult EndustriAkilliFabrika()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var endustri = _Endustriakillifabrikaservice.GetList(dilId = 1);
                return View(endustri);
            }
            else
            {
                var endustri = _Endustriakillifabrikaservice.GetList(dilId);
                return View(endustri);
            }

        }
        public IActionResult EndustriDetay(int id)
        {
            var endustridetay = _Endustriakillifabrikaservice.TGetById(id);
            return View(endustridetay);
        }
        public IActionResult Referanslar()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var referanslar = _referanslarservice.GetList(dilId = 1);
                return View(referanslar);
            }
            else
            {
                var referanslar = _referanslarservice.GetList(dilId);
                return View(referanslar);
            }

        }
        public IActionResult ReferansDetay(int id)
        {
            var referans = _referanslarservice.TGetById(id);
            return View(referans);
        }
        public IActionResult Haberler()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var haberler = _haberservice.GetList(dilId = 1);
                return View(haberler);
            }
            else
            {
                var haberler = _haberservice.GetList(dilId);
                return View(haberler);
            }

        }
        public IActionResult HaberDetay(int id)
        {
            var haber = _haberservice.TGetById(id);
            return View(haber);
        }
        public IActionResult Blog()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var blog = _blogservice.GetList(dilId = 1);
                return View(blog);
            }
            else
            {
                var blog = _blogservice.GetList(dilId);
                return View(blog);
            }

        }
        public IActionResult BlogDetay(int id)
        {
            var blogdetay = _blogservice.TGetById(id);

            return View(blogdetay);

        }
        public IActionResult BlogKategoriDetay(int id)
        {

            Context c = new Context();
            var kategoriyeaitbloglar = c.blogs.Where(x => x.BlogKategoriID == id).ToList();
            return View(kategoriyeaitbloglar);
        }
        public IActionResult DestekPortali()
        {

            var kategoriler = _destekportalikategoriservice.GetList();
            List<SelectListItem> destekkategori = (from i in kategoriler
                                                   select new SelectListItem
                                                   {
                                                       Text = i.Kategori_adi,
                                                       Value = i.Id.ToString()
                                                   }).ToList();
            ViewBag.kategoriler = destekkategori;
            return View();

        }
        [HttpPost]
        public IActionResult DestekPortali(DestekIletisim destekIletisim)
        {
            Context c = new Context();
            c.destekIletisims.Add(destekIletisim);
            c.SaveChanges();
            return RedirectToAction("DestekPortali", "Home");

        }
        public IActionResult KullaniciKilavuzu()
        {
            return View();

        }
        public IActionResult EgitimVideoKategoriler()
        {
            int dilId = Convert.ToInt32(HttpContext.Session.GetInt32("DilId"));
            if (dilId == 0)
            {
                var egitimkategori = _videokategoriservice.GetList(dilId = 1);
                return View(egitimkategori);
            }
            else
            {
                var egitimkategori = _videokategoriservice.GetList(dilId);
                return View(egitimkategori);
            }
        }
        public IActionResult EgitimVideo(int id)
        {
            Context c = new Context();
            var videolar = c.egitimVideolaris.Where(x => x.VideoKategoriID == id).ToList();

            //var izlenecekvideo = egitimvideolarimanager.TGetById(id);
            return View(videolar);
        }

        public IActionResult EgitimVideoDetay(int id)
        {

            var video = _egitimvideolariservice.TGetById(id);
            return View(video);
        }

        public IActionResult CozumlerIcerik()
        {
            return View();
        }
        public IActionResult CozumlerAltIcerik()
        {
            return View();
        }

        public IActionResult KullaniciKlavuzu()
        {

            return View();

        }
        [HttpPost]
        public IActionResult KullaniciKlavuz(int id)

        {
            Context c = new Context();
            var klavuz_icerik = c.kullaniciKlavuzuIceriks.FirstOrDefault(x => x.KMenuId == id);
            return Ok(klavuz_icerik);
        }


        public PartialViewResult IkLoginForm()
        {
            return PartialView("IkLoginForm");
        }
        [HttpPost]
        public PartialViewResult MailBulteni(MailBulteni mailBulteni)
        {
            Context context = new Context();
            context.MailBultenis.Add(mailBulteni);
            context.SaveChanges();
            Response.Redirect("/Home/", true);
            return PartialView();
        }

        [HttpPost]
        public IActionResult FilterBy(int id)
        {
            Context c = new Context();
            var altmenus = c.anasayfaAltMenus.Where(x => x.AnasayfaMenuId == id).ToList();
            return Ok(altmenus);
        }
        public IActionResult Arama(string q)
        {
            var viewModel = new AramaModel();
            viewModel.AramaKey = q;
            //List<Task> TaskList = GetSeachResult(aramakey, viewModel);
            //foreach (Task tsk in TaskList)
            //{
            //    tasks[i] = tsk;
            //    i++;
            //}

            Context context = new Context();
            //var blog = from m in context.blogs
            //           select m;
            if (!string.IsNullOrEmpty(q))
            {
                var hakkimizda = context.hakkimizdas.Where(x => x.Hakkimizda_Baslik!.Contains(q)).ToList();
                var kariyer = context.kariyers.Where(x => x.Kariyer_Konu_baslik!.Contains(q)).ToList();
                var belgelerimiz = context.belgelers.Where(x => x.Belge_isim!.Contains(q)).ToList();
                var arge = context.arges.Where(x => x.Arge_Baslik!.Contains(q)).ToList();
                var iletisim = context.Iletisims.Where(x => x.Iletisim_Adresimiz!.Contains(q)).ToList();
                var uretimtakip = context.uretimTakipYonetimis.Where(x => x.UretimTakip_name!.Contains(q)).ToList();
                var bakimyonetim = context.bakimYonetimis.Where(x => x.BakimYonetimi_isim!.Contains(q)).ToList();
                var enerjiyonetim = context.enerjiYonetimis.Where(x => x.EnerjiYonetimi_isim!.Contains(q)).ToList();
                var kaliteyonetim = context.kaliteYonetimis.Where(x => x.KaliteYonetimi_isim!.Contains(q)).ToList();
                var barkodtakip = context.barkodTakipStoks.Where(x => x.BarkodTakipStok_isim!.Contains(q)).ToList();
                var webmobil = context.webMobils.Where(x => x.WebMobil_isim!.Contains(q)).ToList();
                var entegresistemler = context.entegreSistems.Where(x => x.EntegreSistem_isim!.Contains(q)).ToList();
                var endustri40 = context.endustriAkilliFabrikas.Where(x => x.EndustriAkilliFabrika_isim!.Contains(q)).ToList();
                var referanslar = context.referanslars.Where(x => x.Referanslar_isim!.Contains(q)).ToList();
                var haberler = context.habers.Where(x => x.Haber_isim!.Contains(q)).ToList();
                var blog = context.blogs.Where(x => x.Blog_baslik!.Contains(q)).ToList();
                var isilanlari = context.isilanlaris.Where(x => x.IsYeriAdres!.Contains(q)).ToList();
                var destekportali = context.destekPortalis.Where(x => x.DestekPortali_Baslik!.Contains(q)).ToList();
                var kullanicikilavuz = context.kullaniciKlavuzuIceriks.Where(x => x.Baslik!.Contains(q)).ToList();
                var surumkilavuz = context.surumKilavuzus.Where(x => x.SurumKilavuz_Baslik!.Contains(q)).ToList();
                var egitimvideo = context.egitimVideolaris.Where(x => x.EgitimVideo_Baslik!.Contains(q)).ToList();


                viewModel.hakkimizdas = hakkimizda;
                viewModel.kariyers = kariyer;
                viewModel.belgelers = belgelerimiz;
                viewModel.arges = arge;
                viewModel.ıletisims = iletisim;
                viewModel.uretimTakipYonetimis = uretimtakip;
                viewModel.bakimYonetimis = bakimyonetim;
                viewModel.enerjiYonetimis = enerjiyonetim;
                viewModel.kaliteYonetimis = kaliteyonetim;
                viewModel.barkodTakipStoks = barkodtakip;
                viewModel.webMobils = webmobil;
                viewModel.entegreSistems = entegresistemler;
                viewModel.endustriAkilliFabrikas = endustri40;
                viewModel.referanslars = referanslar;
                viewModel.habers = haberler;
                viewModel.blogs = blog;
                viewModel.isilanlaris = isilanlari;
                viewModel.destekPortalis = destekportali;
                viewModel.kullaniciKlavuzuIceriks = kullanicikilavuz;
                viewModel.surumKilavuzus = surumkilavuz;
                viewModel.egitimVideolaris = egitimvideo;
            }


            return View(viewModel);
        }


    }
}
