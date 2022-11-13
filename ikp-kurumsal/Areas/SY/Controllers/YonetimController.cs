using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using ikp_kurumsal.Areas.SY.Models;
using ikp_kurumsal.Helpers;
using ikp_kurumsal.Helpers.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.Areas.SY.Controllers
{
    [Area("SY")]
    [Authorize(Roles = "Admin")]
    public class YonetimController : Controller
    {

        private readonly IWebHostEnvironment _webHost;
        private readonly UserManager<AppUser> _usermanager;
        private readonly IAnaSayfaKisim1Service _anasayfakisim1service;
        private readonly IAnaSayfaKisim2Service _anasayfakisim2service;
        private readonly IAnaSayfaKisim3Service _anasayfakisim3service;
        private readonly IAnaSayfaKisim4Service _anasayfakisim4service;
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
        private readonly IDestekPortaliService _Destekportaliservice;
        private readonly IArgeService _argeservice;
        private readonly IEgitimVideolariService _egitimvideolariservice;
        private readonly ISurumKilavuzIcerikService _surumklavuzuicerikservice;
        private readonly IAltBilgiService _altBilgiService;
        private readonly IVideoKategoriService _videokategoriservice;
        private readonly IDestekPortaliKategoriService _destekportalikategoriservice;
        private readonly IMenuService _menuservice;
        private readonly IMusterilerimizService _musterilerimizservice;
        private readonly IAnasayfaMenuService _anasayfamenuservice;
        private readonly IAnasayfaAltMenuService _anasayfaAltmenuservice;
        private readonly IHakkimizdaGuncelBilgiService _hakkimizdaGuncelBilgilerservice;
        private readonly IisilanlariService _isilanlariservice;
        private readonly IBlogKategoriService _blogkategoriservice;
        private readonly IKullaniciKlavuzuIcerikService _kullaniciKlavuzuIcerikservice;
        private readonly IOrtamService _ortamService;
        private readonly IImageUploadHelper _imageUploadHelper;
        private readonly IBelgeKategoriService _belgeKategoriService;
        private readonly IArgeGecmisimizService _argeGecmisimizService;
        public YonetimController(IWebHostEnvironment webHost, UserManager<AppUser> usermanager, IAnaSayfaKisim1Service anasayfakisim1service, IAnaSayfaKisim2Service anasayfakisim2service, IAnaSayfaKisim3Service anasayfakisim3service, IAnaSayfaKisim4Service anasayfakisim4service, IEnerjiYonetimiService enerjiyonetimiservice, ISurumKilavuzuService surumklavuzuservice, IHakkimizdaService hakkimizdaservice, IKariyerService kariyerservice, IBelgelerService belgelerservice, IiletisimService iletisimservice, IiletisimMesajService iletisimMesajservice, IUretimTakipYonetimiService urettakipyonetimiservice, IBakimYonetimiService bakimyonetimiservice, IKaliteYonetimiService kaliteYonetimiservice, IBarkodTakipStokService barkodtakipservice, IWebMobilService webmobileservice, IEntegreSistemService entegresistemservice, IEndustriAkilliFabrikaService endustriakillifabrikaservice, IReferanslarService referanslarservice, IHaberService haberservice, IBlogService blogservice, IDestekPortaliService destekportaliservice, IArgeService argeservice, IEgitimVideolariService egitimvideolariservice, ISurumKilavuzIcerikService surumklavuzuicerikservice, IAltBilgiService altBilgiService, IVideoKategoriService videokategoriservice, IDestekPortaliKategoriService destekportalikategoriservice, IMenuService menuservice, IMusterilerimizService musterilerimizservice, IAnasayfaMenuService anasayfamenuservice, IAnasayfaAltMenuService anasayfaAltmenuservice, IHakkimizdaGuncelBilgiService hakkimizdaGuncelBilgilerservice, IisilanlariService isilanlariservice, IBlogKategoriService blogkategoriservice, IKullaniciKlavuzuIcerikService kullaniciKlavuzuIcerikService, IOrtamService ortamService, IImageUploadHelper imageUploadHelper, IBelgeKategoriService belgeKategoriService, IArgeGecmisimizService argeGecmisimizService)
        {
            _webHost = webHost;
            _usermanager = usermanager;
            _anasayfakisim1service = anasayfakisim1service;
            _anasayfakisim2service = anasayfakisim2service;
            _anasayfakisim3service = anasayfakisim3service;
            _anasayfakisim4service = anasayfakisim4service;
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
            _Destekportaliservice = destekportaliservice;
            _argeservice = argeservice;
            _egitimvideolariservice = egitimvideolariservice;
            _surumklavuzuicerikservice = surumklavuzuicerikservice;
            _altBilgiService = altBilgiService;
            _videokategoriservice = videokategoriservice;
            _destekportalikategoriservice = destekportalikategoriservice;
            _menuservice = menuservice;
            _musterilerimizservice = musterilerimizservice;
            _anasayfamenuservice = anasayfamenuservice;
            _anasayfaAltmenuservice = anasayfaAltmenuservice;
            _hakkimizdaGuncelBilgilerservice = hakkimizdaGuncelBilgilerservice;
            _isilanlariservice = isilanlariservice;
            _blogkategoriservice = blogkategoriservice;
            _kullaniciKlavuzuIcerikservice = kullaniciKlavuzuIcerikService;
            _ortamService = ortamService;
            _imageUploadHelper = imageUploadHelper;
            _belgeKategoriService = belgeKategoriService;
            _argeGecmisimizService = argeGecmisimizService;
        }
        public IActionResult SosyalMedyaLink()
        {
            Context c = new Context();
            var linkler = c.SosyalMedyaLinks.FirstOrDefault();

            SosyalMedyaLinkDto dto = new SosyalMedyaLinkDto
            {
                SosyalMedyaLink_id = linkler.SosyalMedyaLink_id,
                InstagramLink = linkler.InstagramLink,
                TwitterLink = linkler.TwitterLink,
                FacebookLink = linkler.FacebookLink,
            };
            return View(dto);
        }

        [HttpPost]
        public IActionResult SosyalMedyaLink(SosyalMedyaLinkDto dto)
        {
            Context c = new Context();
            SosyalMedyaLink linkler = new SosyalMedyaLink
            {
                SosyalMedyaLink_id = dto.SosyalMedyaLink_id,
                InstagramLink = dto.InstagramLink,
                TwitterLink = dto.TwitterLink,
                FacebookLink = dto.FacebookLink,
            };
            c.SosyalMedyaLinks.Update(linkler);
            c.SaveChanges();
            return RedirectToAction("SosyalMedyaLink", "Yonetim");
        }

        [HttpGet]
        public IActionResult Musterilerimizhkk()
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
        public async Task<IActionResult> Musterilerimizhkk(Musterilerimiz musterilerimiz)
        {
            if (ModelState.IsValid)
            {

                if (musterilerimiz.MusterilerimizResim != null)
                {

                    musterilerimiz.MusterilerimizYol = await _imageUploadHelper.Upload(musterilerimiz.MusterilerimizResim, "/Resimler/Musterilerimiz/");

                }

                _musterilerimizservice.TAdd(musterilerimiz);
            }
            return RedirectToAction("Musterilerimizhkk", "Yonetim");
        }
        public IActionResult MusterilerimizhkkDuzenle(int id)
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
            var duzenlenecek = _musterilerimizservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> MusterilerimizhkkDuzenle(Musterilerimiz musterilerimiz)
        {
            if (ModelState.IsValid)
            {
                if (musterilerimiz.MusterilerimizResim != null)
                {
                    _imageUploadHelper.Delete("/Resimler/Musterilerimiz/", musterilerimiz.MusterilerimizYol);
                    musterilerimiz.MusterilerimizYol = await _imageUploadHelper.Upload(musterilerimiz.MusterilerimizResim, "/Resimler/Musterilerimiz/");
                }

                _musterilerimizservice.TUpdate(musterilerimiz);
            }
            return RedirectToAction("Musterilerimizhkk", "Yonetim");
        }
        public IActionResult MusterilerimizhkkSil(int id)
        {
            var silinecek = _musterilerimizservice.TGetById(id);
            _musterilerimizservice.TDelete(silinecek);
            return RedirectToAction("Musterilerimizhkk", "Yonetim");
        }

        [HttpGet]
        public IActionResult SliderEkle()
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
        public async Task<IActionResult> SliderEkle(AnaSayfaKisim1 anaSayfaKisim1)
        {
            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(anaSayfaKisim1.Resim.FileName);
            string extension = Path.GetExtension(anaSayfaKisim1.Resim.FileName);
            anaSayfaKisim1.ResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/Resimler/Slider/", filename);
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await anaSayfaKisim1.Resim.CopyToAsync(filestream);
            }
            _anasayfakisim1service.TAdd(anaSayfaKisim1);
            return RedirectToAction("SliderEkle", "Yonetim");
        }
        public IActionResult SliderDuzenle(int id)
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
            var duzenlenecek = _anasayfakisim1service.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> SliderDuzenle(AnaSayfaKisim1 anaSayfaKisim1)
        {
            if (anaSayfaKisim1.Resim != null)
            {
                string wwwRootPath = _webHost.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(anaSayfaKisim1.Resim.FileName);
                string extension = Path.GetExtension(anaSayfaKisim1.Resim.FileName);
                anaSayfaKisim1.ResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Resimler/Slider/", filename);
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await anaSayfaKisim1.Resim.CopyToAsync(filestream);
                }
            }

            _anasayfakisim1service.TUpdate(anaSayfaKisim1);
            return RedirectToAction("SliderEkle", "Yonetim");
        }
        public IActionResult SliderSil(int id)
        {
            var silinecek = _anasayfakisim1service.TGetById(id);
            _anasayfakisim1service.TDelete(silinecek);
            return RedirectToAction("SliderEkle", "Yonetim");
        }

        [HttpGet]
        public IActionResult CozumlerimizEkle()
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
        public IActionResult CozumlerimizEkle(AnaSayfaKisim2 anaSayfaKisim2)
        {
            _anasayfakisim2service.TAdd(anaSayfaKisim2);
            return RedirectToAction("CozumlerimizEkle", "Yonetim");
        }
        public IActionResult CozumlerimizDuzenle(int id)
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
            var duzenlenecek = _anasayfakisim2service.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public IActionResult CozumlerimizDuzenle(AnaSayfaKisim2 anaSayfaKisim2)
        {
            _anasayfakisim2service.TUpdate(anaSayfaKisim2);
            return RedirectToAction("CozumlerimizEkle", "Yonetim");
        }
        public IActionResult CozumlerimizSil(int id)
        {
            var silinecek = _anasayfakisim2service.TGetById(id);
            _anasayfakisim2service.TDelete(silinecek);
            return RedirectToAction("CozumlerimizEkle", "Yonetim");
        }

        [HttpGet]
        public IActionResult MusterilerimizEkle()
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
        public IActionResult MusterilerimizEkle(AnaSayfaKisim3 anaSayfaKisim3)
        {
            _anasayfakisim3service.TAdd(anaSayfaKisim3);
            return RedirectToAction("MusterilerimizEkle", "Yonetim");
        }
        public IActionResult MusterilerimizDuzenle(int id)
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
            var duzenlenecek = _anasayfakisim3service.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public IActionResult MusterilerimizDuzenle(AnaSayfaKisim3 anaSayfaKisim3)
        {
            _anasayfakisim3service.TUpdate(anaSayfaKisim3);
            return RedirectToAction("MusterilerimizEkle", "Yonetim");
        }
        public IActionResult MusterilerimizSil(int id)
        {
            var silinecek = _anasayfakisim3service.TGetById(id);
            _anasayfakisim3service.TDelete(silinecek);
            return RedirectToAction("MusterilerimizEkle", "Yonetim");
        }

        [HttpGet]
        public IActionResult PortfolyoEkle()
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
        public async Task<IActionResult> PortfolyoEkle(AnaSayfaKisim4 anaSayfaKisim4)
        {
            if (ModelState.IsValid)
            {

                if (anaSayfaKisim4.AnaSayfaResim4 != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(anaSayfaKisim4.AnaSayfaResim4.FileName);
                    string extension = Path.GetExtension(anaSayfaKisim4.AnaSayfaResim4.FileName);
                    anaSayfaKisim4.AnaSayfaResim4Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/AnaSayfaResim/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await anaSayfaKisim4.AnaSayfaResim4.CopyToAsync(filestream);
                    }


                }
                _anasayfakisim4service.TAdd(anaSayfaKisim4);
            }
            return RedirectToAction("PortfolyoEkle", "Yonetim");
        }
        public IActionResult PortfolyoDuzenle(int id)
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
            var duzenlenecek = _anasayfakisim4service.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> PortfolyoDuzenle(AnaSayfaKisim4 anaSayfaKisim4)
        {
            if (ModelState.IsValid)
            {
                if (anaSayfaKisim4.AnaSayfaResim4 != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(anaSayfaKisim4.AnaSayfaResim4.FileName);
                    string extension = Path.GetExtension(anaSayfaKisim4.AnaSayfaResim4.FileName);
                    anaSayfaKisim4.AnaSayfaResim4Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/AnaSayfaResim/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await anaSayfaKisim4.AnaSayfaResim4.CopyToAsync(filestream);
                    }
                }
                _anasayfakisim4service.TUpdate(anaSayfaKisim4);
            }
            return RedirectToAction("PortfolyoEkle", "Yonetim");
        }
        public IActionResult PortfolyoSil(int id)
        {
            var silinecek = _anasayfakisim4service.TGetById(id);
            _anasayfakisim4service.TDelete(silinecek);
            return RedirectToAction("PortfolyoEkle", "Yonetim");
        }


        public IActionResult AnaSayfa()
        {
            return View();
        }
        public IActionResult Basliklar()
        {
            return View();
        }
        [HttpGet]
        public IActionResult HakkimizdaEkle()
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
        public async Task<IActionResult> HakkimizdaEkle(Hakkimizda hakkimizda)
        {
            if (ModelState.IsValid)
            {
                if (hakkimizda.BannerResim != null)
                {
                    string bannerName = await _imageUploadHelper.Upload(hakkimizda.BannerResim, "/Resimler/HakkimizdaBanner/");
                    hakkimizda.BannerResimYol = bannerName;

                }

                if (hakkimizda.EkibimizResim != null)
                {
                    string ekibimizResimName = await _imageUploadHelper.Upload(hakkimizda.EkibimizResim, "/Resimler/EkipResim/");
                    hakkimizda.EkibimizResimYol = ekibimizResimName;

                }

                _hakkimizdaservice.TAdd(hakkimizda);

            }
            return RedirectToAction("HakkimizdaEkle", "Yonetim");
        }
        public IActionResult HakkimizdaDuzenle(int id)
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
            var hakkimizda = _hakkimizdaservice.TGetById(id);
            return View(hakkimizda);
        }
        [HttpPost]
        public async Task<IActionResult> HakkimizdaDuzenle(Hakkimizda hakkimizda)
        {
            if (ModelState.IsValid)
            {
                if (hakkimizda.BannerResim != null)
                {
                    _imageUploadHelper.Delete("/Resimler/HakkimizdaBanner/", hakkimizda.BannerResimYol);
                    hakkimizda.BannerResimYol = await _imageUploadHelper.Upload(hakkimizda.BannerResim, "/Resimler/HakkimizdaBanner/");
                }

                if (hakkimizda.EkibimizResim != null)
                {
                    _imageUploadHelper.Delete("/Resimler/EkipResim/", hakkimizda.EkibimizResimYol);
                    hakkimizda.EkibimizResimYol = await _imageUploadHelper.Upload(hakkimizda.EkibimizResim, "/Resimler/EkipResim/");
                }
                //string wwwRootPath = _webHost.WebRootPath;
                //string filename = Path.GetFileNameWithoutExtension(hakkimizda.Hakkimizda_Ekibimiz_Resim.FileName);
                //string filename2 = Path.GetFileNameWithoutExtension(hakkimizda.Biz_kimiz_resim.FileName);
                //string extension = Path.GetExtension(hakkimizda.Hakkimizda_Ekibimiz_Resim.FileName);
                //string extension2 = Path.GetExtension(hakkimizda.Biz_kimiz_resim.FileName);
                //hakkimizda.Hakkimizda_Ekibimiz_Resim_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                //hakkimizda.Biz_kimiz_resim_yol = filename2 = filename2 + DateTime.Now.ToString("yymmssfff") + extension2;
                //string path = Path.Combine(wwwRootPath + "/Resimler/Ekipresim/", filename);
                //string path2 = Path.Combine(wwwRootPath + "/Resimler/BizKimiz/", filename2);
                //using (var filestream = new FileStream(path, FileMode.Create))
                //{
                //    await hakkimizda.Hakkimizda_Ekibimiz_Resim.CopyToAsync(filestream);
                //}
                //using (var filestream2 = new FileStream(path2, FileMode.Create))
                //{
                //    await hakkimizda.Biz_kimiz_resim.CopyToAsync(filestream2);
                //}
                _hakkimizdaservice.TUpdate(hakkimizda);
                return RedirectToAction("HakkimizdaEkle", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult HakkimizdaSil(int id)
        {
            var silinecek = _hakkimizdaservice.TGetById(id);
            _hakkimizdaservice.TDelete(silinecek);
            return RedirectToAction("HakkimizdaEkle", "Yonetim");
        }

        public IActionResult Kariyer()
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
        public async Task<IActionResult> Kariyer(Kariyer kariyer)
        {
            if (ModelState.IsValid)
            {
                if (kariyer.Kariyer_resim != null)
                {
                    kariyer.Kariyer_resim_yol = await _imageUploadHelper.Upload(kariyer.Kariyer_resim, "/Resimler/KariyerResim/");
                }

                _kariyerservice.TAdd(kariyer);
            }

            return RedirectToAction("Kariyer", "Yonetim");
        }
        public IActionResult KariyerDuzenle(int id)
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
            var duzenlenecek = _kariyerservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> KariyerDuzenle(Kariyer kariyer)
        {
            if (ModelState.IsValid)
            {
                if (kariyer.Kariyer_resim != null)
                {
                    _imageUploadHelper.Delete("/Resimler/KariyerResim/", kariyer.Kariyer_resim_yol);
                    kariyer.Kariyer_resim_yol = await _imageUploadHelper.Upload(kariyer.Kariyer_resim, "/Resimler/KariyerResim/");
                }

                _kariyerservice.TUpdate(kariyer);
            }

            return RedirectToAction("Kariyer", "Yonetim");
        }

        public IActionResult KariyerSil(int id)
        {
            var silinecek = _kariyerservice.TGetById(id);
            _kariyerservice.TDelete(silinecek);
            return RedirectToAction("Kariyer", "Yonetim");
        }

        public IActionResult BelgeEkle()
        {
            ViewBag.BelgeKategoriList = _belgeKategoriService.GetList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BelgeEkle(Belgeler Belge)
        {
            if (ModelState.IsValid)
            {
                if (Belge.Belge_Resim != null)
                {
                    Belge.Belge_Resim_Yol = await _imageUploadHelper.Upload(Belge.Belge_Resim, "/Resimler/Belgeler/");
                }

                _belgelerservice.TAdd(Belge);
            }
            return RedirectToAction("BelgeEkle", "Yonetim");
        }
        public IActionResult BelgeDuzenle(int id)
        {
            var belge = _belgelerservice.TGetById(id);
            ViewBag.BelgeKategoriList = _belgeKategoriService.GetList();
            return View(belge);
        }
        [HttpPost]
        public async Task<IActionResult> BelgeDuzenle(Belgeler Belge)
        {
            if (ModelState.IsValid)
            {
                if (Belge.Belge_Resim != null)
                {
                    _imageUploadHelper.Delete("/Resimler/Belgeler/", Belge.Belge_Resim_Yol);
                    Belge.Belge_Resim_Yol = await _imageUploadHelper.Upload(Belge.Belge_Resim, "/Resimler/Belgeler/");
                }

                _belgelerservice.TUpdate(Belge);

            }
            return RedirectToAction("BelgeEkle", "Yonetim");
        }
        public IActionResult BelgeSil(int id)
        {
            var silincekbelge = _belgelerservice.TGetById(id);
            _belgelerservice.TDelete(silincekbelge);
            return RedirectToAction("BelgeEkle", "Yonetim");
        }
        public IActionResult BelgeKategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BelgeKategoriEkle(BelgeKategori belgeKategori)
        {
            if (ModelState.IsValid)
            {
                _belgeKategoriService.TAdd(belgeKategori);
            }
            return View();
        }
        public IActionResult BelgeKategoriDuzenle(int id)
        {
            var belge = _belgeKategoriService.TGetById(id);
            return View(belge);
        }
        [HttpPost]
        public IActionResult BelgeKategoriDuzenle(BelgeKategori belgeKategori)
        {
            if (ModelState.IsValid)
            {
                _belgeKategoriService.TUpdate(belgeKategori);

            }
            return RedirectToAction("BelgeKategoriEkle", "Yonetim");
        }

        public IActionResult BelgeKategoriSil(int id)
        {
            var silincekbelge = _belgeKategoriService.TGetById(id);
            _belgeKategoriService.TDelete(silincekbelge);
            return RedirectToAction("BelgeKategoriEkle", "Yonetim");
        }


        public IActionResult UretimTakipYonetimi()
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
        public async Task<IActionResult> UretimTakipYonetimi(UretimTakipYonetimi uretimtakip)
        {
            if (ModelState.IsValid)
            {
                if (uretimtakip.UretimTakip_Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(uretimtakip.UretimTakip_Resim.FileName);
                    string extension = Path.GetExtension(uretimtakip.UretimTakip_Resim.FileName);

                    uretimtakip.UretimTakip_Resim_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/UretimTakip/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await uretimtakip.UretimTakip_Resim.CopyToAsync(filestream);
                    }
                }

                _urettakipyonetimiservice.TAdd(uretimtakip);
            }

            return RedirectToAction("UretimTakipYonetimi");
        }
        public IActionResult UretimTakipYonetimiDuzenle(int id)
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
            var duzenlenecek = _urettakipyonetimiservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> UretimTakipYonetimiDuzenle(UretimTakipYonetimi uretimtakipyonetimi)
        {
            if (ModelState.IsValid)
            {
                if (uretimtakipyonetimi.UretimTakip_Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(uretimtakipyonetimi.UretimTakip_Resim.FileName);
                    string extension = Path.GetExtension(uretimtakipyonetimi.UretimTakip_Resim.FileName);
                    uretimtakipyonetimi.UretimTakip_Resim_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/UretimTakip/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await uretimtakipyonetimi.UretimTakip_Resim.CopyToAsync(filestream);
                    }
                }

                _urettakipyonetimiservice.TUpdate(uretimtakipyonetimi);
                return RedirectToAction("UretimTakipYonetimi", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult UretimTakipYonetimiSil(int id)
        {
            var silinecek = _urettakipyonetimiservice.TGetById(id);
            _urettakipyonetimiservice.TDelete(silinecek);
            return RedirectToAction("UretimTakipYonetimi", "Yonetim");
        }
        public IActionResult BakimYonetimi()
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
        public async Task<IActionResult> BakimYonetimi(BakimYonetimi bakimyonetimi)
        {
            if (ModelState.IsValid)
            {
                if (bakimyonetimi.BakimYonetimi_Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(bakimyonetimi.BakimYonetimi_Resim.FileName);
                    string extension = Path.GetExtension(bakimyonetimi.BakimYonetimi_Resim.FileName);
                    bakimyonetimi.BakimYonetimi_Resim_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/BakimYonetimi/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await bakimyonetimi.BakimYonetimi_Resim.CopyToAsync(filestream);
                    }
                }

                _Bakimyonetimiservice.TAdd(bakimyonetimi);
            }

            return RedirectToAction("BakimYonetimi");
        }
        public IActionResult BakimYonetimiDuzenle(int id)
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
            var duzenlenecek = _Bakimyonetimiservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> BakimYonetimiDuzenle(BakimYonetimi bakimyonetimi)
        {
            if (ModelState.IsValid)
            {
                if (bakimyonetimi.BakimYonetimi_Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(bakimyonetimi.BakimYonetimi_Resim.FileName);
                    string extension = Path.GetExtension(bakimyonetimi.BakimYonetimi_Resim.FileName);
                    bakimyonetimi.BakimYonetimi_Resim_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/BakimYonetimi/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await bakimyonetimi.BakimYonetimi_Resim.CopyToAsync(filestream);
                    }
                }

                _Bakimyonetimiservice.TUpdate(bakimyonetimi);
                return RedirectToAction("BakimYonetimi", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult BakimYonetimiSil(int id)
        {
            var silinecek = _Bakimyonetimiservice.TGetById(id);
            _Bakimyonetimiservice.TDelete(silinecek);
            return RedirectToAction("BakimYonetimi", "Yonetim");
        }
        public IActionResult EnerjiYonetimi()
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
        public async Task<IActionResult> EnerjiYonetimi(EnerjiYonetimi enerjiyonetimi)
        {
            if (ModelState.IsValid)
            {
                if (enerjiyonetimi.EnerjiYonetimi_Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(enerjiyonetimi.EnerjiYonetimi_Resim.FileName);
                    string extension = Path.GetExtension(enerjiyonetimi.EnerjiYonetimi_Resim.FileName);
                    enerjiyonetimi.EnerjiYonetimi_ResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/EnerjiYonetimi/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await enerjiyonetimi.EnerjiYonetimi_Resim.CopyToAsync(filestream);
                    }
                }

                _enerjiyonetimiservice.TAdd(enerjiyonetimi);
            }

            return RedirectToAction("EnerjiYonetimi");
        }

        public IActionResult EnerjiYonetimiDuzenle(int id)
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
            var duzenlenicek = _enerjiyonetimiservice.TGetById(id);
            return View(duzenlenicek);
        }
        [HttpPost]
        public async Task<IActionResult> EnerjiYonetimiDuzenle(EnerjiYonetimi enerjiyonetimi)
        {
            if (ModelState.IsValid)
            {
                if (enerjiyonetimi.EnerjiYonetimi_Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(enerjiyonetimi.EnerjiYonetimi_Resim.FileName);
                    string extension = Path.GetExtension(enerjiyonetimi.EnerjiYonetimi_Resim.FileName);
                    enerjiyonetimi.EnerjiYonetimi_ResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/EnerjiYonetimi/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await enerjiyonetimi.EnerjiYonetimi_Resim.CopyToAsync(filestream);
                    }
                }

                _enerjiyonetimiservice.TUpdate(enerjiyonetimi);

                return RedirectToAction("EnerjiYonetimi", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult EnerjiYonetimiSil(int id)
        {
            var silinecek = _enerjiyonetimiservice.TGetById(id);
            _enerjiyonetimiservice.TDelete(silinecek);
            return RedirectToAction("EnerjiYonetimi", "Yonetim");
        }


        public IActionResult KaliteYonetimi()
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
        public async Task<IActionResult> KaliteYonetimi(KaliteYonetimi kaliteyonetimi)
        {
            if (ModelState.IsValid)
            {
                if (kaliteyonetimi.KaliteYonetimi_Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(kaliteyonetimi.KaliteYonetimi_Resim.FileName);
                    string extension = Path.GetExtension(kaliteyonetimi.KaliteYonetimi_Resim.FileName);
                    kaliteyonetimi.KaliteYonetimi_Resim_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/KaliteYonetimi/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await kaliteyonetimi.KaliteYonetimi_Resim.CopyToAsync(filestream);
                    }
                }

                _KaliteYonetimiservice.TAdd(kaliteyonetimi);
            }

            return RedirectToAction("KaliteYonetimi");
        }
        public IActionResult KaliteYonetimiDuzenle(int id)
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
            var duzenlenecek = _KaliteYonetimiservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> KaliteYonetimiDuzenle(KaliteYonetimi kaliteyonetimi)
        {
            if (ModelState.IsValid)
            {
                if (kaliteyonetimi.KaliteYonetimi_Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(kaliteyonetimi.KaliteYonetimi_Resim.FileName);
                    string extension = Path.GetExtension(kaliteyonetimi.KaliteYonetimi_Resim.FileName);
                    kaliteyonetimi.KaliteYonetimi_Resim_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/KaliteYonetimi/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await kaliteyonetimi.KaliteYonetimi_Resim.CopyToAsync(filestream);
                    }
                }

                _KaliteYonetimiservice.TUpdate(kaliteyonetimi);
                return RedirectToAction("KaliteYonetimi", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult KaliteYonetimiSil(int id)
        {
            var silincek = _KaliteYonetimiservice.TGetById(id);
            _KaliteYonetimiservice.TDelete(silincek);
            return RedirectToAction("KaliteYonetimi", "Yonetim");
        }

        public IActionResult BarkodTakipliStokYonetimiEkle()
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
        public async Task<ActionResult> BarkodTakipliStokYonetimiEkle(BarkodTakipStok barkodtakipstok)
        {
            if (ModelState.IsValid)
            {
                if (barkodtakipstok.BarkodTakipStok_Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(barkodtakipstok.BarkodTakipStok_Resim.FileName);
                    string extension = Path.GetExtension(barkodtakipstok.BarkodTakipStok_Resim.FileName);
                    barkodtakipstok.BarkodTakipStok_Resim_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/BarkodTakipStok/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await barkodtakipstok.BarkodTakipStok_Resim.CopyToAsync(filestream);
                    }
                }

                _Barkodtakipservice.TAdd(barkodtakipstok);

            }

            return RedirectToAction("BarkodTakipliStokYonetimiEkle");

        }

        public IActionResult BarkodTakipliStokYonetimiDuzenle(int id)
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
            var duzenlenecek = _Barkodtakipservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> BarkodTakipliStokYonetimiDuzenle(BarkodTakipStok barkodtakipstok)
        {
            if (ModelState.IsValid)
            {
                if (barkodtakipstok.BarkodTakipStok_Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(barkodtakipstok.BarkodTakipStok_Resim.FileName);
                    string extension = Path.GetExtension(barkodtakipstok.BarkodTakipStok_Resim.FileName);
                    barkodtakipstok.BarkodTakipStok_Resim_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/BarkodTakipStok/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await barkodtakipstok.BarkodTakipStok_Resim.CopyToAsync(filestream);
                    }
                }

                _Barkodtakipservice.TUpdate(barkodtakipstok);
                return RedirectToAction("BarkodTakipliStokYonetimiEkle", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult BarkodTakipliStokYonetimiSil(int id)
        {
            var silinecek = _Barkodtakipservice.TGetById(id);
            _Barkodtakipservice.TDelete(silinecek);
            return RedirectToAction("BarkodTakipliStokYonetimiEkle", "Yonetim");
        }

        public IActionResult WebMobileMonitoringEkle()
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
        public async Task<IActionResult> WebMobileMonitoringEkle(WebMobil webmobil)
        {
            if (ModelState.IsValid)
            {
                if (webmobil.WebMobil_resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(webmobil.WebMobil_resim.FileName);
                    string extension = Path.GetExtension(webmobil.WebMobil_resim.FileName);
                    webmobil.WebMobil_resim_yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/WebMobil/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await webmobil.WebMobil_resim.CopyToAsync(filestream);
                    }
                }

                _webmobileservice.TAdd(webmobil);

            }

            return RedirectToAction("WebMobileMonitoringEkle");

        }

        public IActionResult WebMobileMonitoringDuzenle(int id)
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
            var duzenlenecek = _webmobileservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> WebMobileMonitoringDuzenle(WebMobil webMobil)
        {
            if (ModelState.IsValid)
            {
                if (webMobil.WebMobil_resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(webMobil.WebMobil_resim.FileName);
                    string extension = Path.GetExtension(webMobil.WebMobil_resim.FileName);
                    webMobil.WebMobil_resim_yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/WebMobil/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await webMobil.WebMobil_resim.CopyToAsync(filestream);
                    }
                }

                _webmobileservice.TUpdate(webMobil);
                return RedirectToAction("WebMobileMonitoringEkle", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult WebMobileMonitoringSil(int id)
        {
            var silinecek = _webmobileservice.TGetById(id);
            _webmobileservice.TDelete(silinecek);
            return RedirectToAction("WebMobileMonitoringEkle", "Yonetim");
        }

        public IActionResult EntegreSistemlerEkle()
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
        public async Task<IActionResult> EntegreSistemlerEkle(EntegreSistem entegresistemler)
        {
            if (ModelState.IsValid)
            {
                if (entegresistemler.EntegreSistem_resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(entegresistemler.EntegreSistem_resim.FileName);
                    string extension = Path.GetExtension(entegresistemler.EntegreSistem_resim.FileName);
                    entegresistemler.EntegreSistem_resim_yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/EntegreSistemler/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await entegresistemler.EntegreSistem_resim.CopyToAsync(filestream);
                    }
                }

                _Entegresistemservice.TAdd(entegresistemler);

            }

            return RedirectToAction("EntegreSistemlerEkle");

        }

        public IActionResult EntegreSistemlerDuzenle(int id)
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
            var duzenlecek = _Entegresistemservice.TGetById(id);
            return View(duzenlecek);
        }
        [HttpPost]
        public async Task<IActionResult> EntegreSistemlerDuzenle(EntegreSistem entegresistem)
        {
            if (ModelState.IsValid)
            {
                if (entegresistem.EntegreSistem_resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(entegresistem.EntegreSistem_resim.FileName);
                    string extension = Path.GetExtension(entegresistem.EntegreSistem_resim.FileName);
                    entegresistem.EntegreSistem_resim_yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/EntegreSistemler/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await entegresistem.EntegreSistem_resim.CopyToAsync(filestream);
                    }
                }

                _Entegresistemservice.TUpdate(entegresistem);
                return RedirectToAction("EntegreSistemlerEkle", "Yonetim");
            }
            else
            {
                return View();
            }
        }

        public IActionResult EntegreSistemlerSil(int id)
        {
            var silinecek = _Entegresistemservice.TGetById(id);
            _Entegresistemservice.TDelete(silinecek);
            return RedirectToAction("EntegreSistemlerEkle", "Yonetim");
        }

        public IActionResult ReferansEkle()
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
        public async Task<IActionResult> ReferansEkle(Referanslar referans)
        {
            if (ModelState.IsValid)
            {
                if (referans.Referanslar_resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(referans.Referanslar_resim.FileName);
                    string extension = Path.GetExtension(referans.Referanslar_resim.FileName);
                    referans.Referanslar_resim_yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/Referanslar/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await referans.Referanslar_resim.CopyToAsync(filestream);
                    }
                }

                _referanslarservice.TAdd(referans);

            }

            return RedirectToAction("ReferansEkle", "Yonetim");
        }
        public IActionResult ReferanslarDuzenle(int id)
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
            var duzenlenecek = _referanslarservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> ReferanslarDuzenle(Referanslar referans)
        {
            if (ModelState.IsValid)
            {
                if (referans.Referanslar_resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(referans.Referanslar_resim.FileName);
                    string extension = Path.GetExtension(referans.Referanslar_resim.FileName);
                    referans.Referanslar_resim_yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/Referanslar/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await referans.Referanslar_resim.CopyToAsync(filestream);
                    }
                }

                _referanslarservice.TUpdate(referans);
            }

            return RedirectToAction("ReferansEkle", "Yonetim");
        }

        public IActionResult ReferanslarSil(int id)
        {
            var silinecek = _referanslarservice.TGetById(id);
            _referanslarservice.TDelete(silinecek);
            return RedirectToAction("ReferansEkle", "Yonetim");
        }

        public IActionResult HaberEkle()
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
        public async Task<IActionResult> HaberEkle(Haber haber)
        {
            if (ModelState.IsValid)
            {
                if (haber.Haber_resim != null)
                {
                    haber.Haber_resim_yol = await _imageUploadHelper.Upload(haber.Haber_resim, "/Resimler/Haberler/");
                }

                _haberservice.TAdd(haber);
            }
            return RedirectToAction("HaberEkle", "Yonetim");
        }

        public IActionResult HaberDuzenle(int id)
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
            var duzenlenecekhaber = _haberservice.TGetById(id);
            return View(duzenlenecekhaber);
        }

        [HttpPost]
        public async Task<IActionResult> HaberDuzenle(Haber haber)
        {
            if (ModelState.IsValid)
            {
                if (haber.Haber_resim != null)
                {
                    _imageUploadHelper.Delete("/Resimler/Haberler/", haber.Haber_resim_yol);
                    haber.Haber_resim_yol = await _imageUploadHelper.Upload(haber.Haber_resim, "/Resimler/Haberler/");
                }

                _haberservice.TUpdate(haber);
            }

            return RedirectToAction("HaberEkle", "Yonetim");
        }

        public IActionResult HaberSil(int id)
        {
            var silinecekhaber = _haberservice.TGetById(id);
            _haberservice.TDelete(silinecekhaber);
            return RedirectToAction("HaberEkle", "Yonetim");
        }

        public IActionResult BlogEkle()
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
            var kategoriler = _blogkategoriservice.GetList();
            List<SelectListItem> blogkategori = (from i in kategoriler
                                                 select new SelectListItem
                                                 {
                                                     Text = i.BlogKategoriAdi,
                                                     Value = i.ID.ToString()
                                                 }).ToList();
            ViewBag.kategoriler = blogkategori;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BlogEkle(Blog blog)
        {
            if (ModelState.IsValid)
            {
                if (blog.Blog_resim != null)
                {
                    blog.Blog_resim_yol = await _imageUploadHelper.Upload(blog.Blog_resim, "/Resimler/Bloglar/");
                }
                _blogservice.TAdd(blog);
            }

            return RedirectToAction("BlogEkle", "Yonetim");
        }

        public IActionResult BlogDuzenle(int id)
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
            var kategoriler = _blogkategoriservice.GetList();
            List<SelectListItem> blogkategori = (from i in kategoriler
                                                 select new SelectListItem
                                                 {
                                                     Text = i.BlogKategoriAdi,
                                                     Value = i.ID.ToString()
                                                 }).ToList();
            ViewBag.kategoriler = blogkategori;

            var duzenlenecekhaber = _blogservice.TGetById(id);
            return View(duzenlenecekhaber);
        }
        [HttpPost]
        public async Task<IActionResult> BlogDuzenle(Blog blog)
        {
            if (ModelState.IsValid)
            {
                if (blog.Blog_resim != null)
                {
                    _imageUploadHelper.Delete("/Resimler/Bloglar/", blog.Blog_resim_yol);
                    blog.Blog_resim_yol = await _imageUploadHelper.Upload(blog.Blog_resim, "/Resimler/Bloglar/");
                }
                _blogservice.TUpdate(blog);
            }

            return RedirectToAction("BlogEkle", "Yonetim");
        }

        public IActionResult BlogSil(int id)
        {
            var silinecekblog = _blogservice.TGetById(id);
            _blogservice.TDelete(silinecekblog);
            return RedirectToAction("BlogEkle", "Yonetim");
        }
        [HttpGet]
        public IActionResult BlogKategoriEkle()
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
        public async Task<IActionResult> BlogKategoriEkle(BlogKategori blogKategori)
        {
            if (ModelState.IsValid)
            {
                if (blogKategori.KategoriResim != null)
                {
                    blogKategori.KategoriResimYol = await _imageUploadHelper.Upload(blogKategori.KategoriResim, "/Resimler/BlogKategori/");
                }

                _blogkategoriservice.TAdd(blogKategori);
            }

            return RedirectToAction("BlogKategoriEkle", "Yonetim");
        }
        [HttpGet]
        public IActionResult BlogKategoriGuncelle(int id)
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
            var guncellenecek = _blogkategoriservice.TGetById(id);
            return View(guncellenecek);
        }
        [HttpPost]
        public async Task<IActionResult> BlogKategoriGuncelle(BlogKategori blogKategori)
        {
            if (ModelState.IsValid)
            {
                if (blogKategori.KategoriResim != null)
                {
                    _imageUploadHelper.Delete("/Resimler/BlogKategori/", blogKategori.KategoriResimYol);
                    blogKategori.KategoriResimYol = await _imageUploadHelper.Upload(blogKategori.KategoriResim, "/Resimler/BlogKategori/");
                }

                _blogkategoriservice.TUpdate(blogKategori);
            }

            return RedirectToAction("BlogKategoriEkle", "Yonetim");
        }
        public IActionResult BlogKategoriSil(int id)
        {
            var silinecekKategori = _blogkategoriservice.TGetById(id);
            _blogkategoriservice.TDelete(silinecekKategori);
            return RedirectToAction("BlogKategoriEkle", "Yonetim");
        }
        public IActionResult DestekPortali()
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
        public IActionResult DestekPortali(DestekPortali destekportali)
        {
            if (ModelState.IsValid)
            {
                _Destekportaliservice.TAdd(destekportali);
                return View();
            }
            else
            {
                return View();
            }
        }

        public IActionResult DestekPortaliDuzenle(int id)
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
            var duzenlenecekdestek = _Destekportaliservice.TGetById(id);
            return View(duzenlenecekdestek);
        }
        [HttpPost]
        public IActionResult DestekPortaliDuzenle(DestekPortali destekportali)
        {
            if (ModelState.IsValid)
            {
                _Destekportaliservice.TUpdate(destekportali);
                return RedirectToAction("DestekPortali", "Yonetim");
            }
            else
            {
                return View();
            }
        }

        public IActionResult DestekPortaliSil(int id)
        {
            var silinecekveri = _Destekportaliservice.TGetById(id);
            _Destekportaliservice.TDelete(silinecekveri);
            return RedirectToAction("DestekPortali", "Yonetim");
        }
        public IActionResult EndustriAkilliFabrika()
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
        public async Task<IActionResult> EndustriAkilliFabrika(EndustriAkilliFabrika endustriakillifabrika)
        {
            if (ModelState.IsValid)
            {
                if (endustriakillifabrika.EndustriAkilliFabrika_resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(endustriakillifabrika.EndustriAkilliFabrika_resim.FileName);
                    string extension = Path.GetExtension(endustriakillifabrika.EndustriAkilliFabrika_resim.FileName);
                    endustriakillifabrika.EndustriAkilliFabrika_resim_yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/EndustriAkilliFabrika/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await endustriakillifabrika.EndustriAkilliFabrika_resim.CopyToAsync(filestream);
                    }
                }

                _Endustriakillifabrikaservice.TAdd(endustriakillifabrika);

            }
            return RedirectToAction("EndustriAkilliFabrika", "Yonetim");

        }
        public IActionResult EndustriAkilliFabrikaDuzenle(int id)
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
            var duzenlenecek = _Endustriakillifabrikaservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> EndustriAkilliFabrikaDuzenle(EndustriAkilliFabrika endustriakillifabrika)
        {
            if (ModelState.IsValid)
            {
                if (endustriakillifabrika.EndustriAkilliFabrika_resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(endustriakillifabrika.EndustriAkilliFabrika_resim.FileName);
                    string extension = Path.GetExtension(endustriakillifabrika.EndustriAkilliFabrika_resim.FileName);
                    endustriakillifabrika.EndustriAkilliFabrika_resim_yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/EndustriAkilliFabrika/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await endustriakillifabrika.EndustriAkilliFabrika_resim.CopyToAsync(filestream);
                    }
                }

                _Endustriakillifabrikaservice.TUpdate(endustriakillifabrika);
                return RedirectToAction("EndustriAkilliFabrika", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult EndustriAkilliFabrikaSil(int id)
        {
            var silinecek = _Endustriakillifabrikaservice.TGetById(id);
            _Endustriakillifabrikaservice.TDelete(silinecek);
            return RedirectToAction("EndustriAkilliFabrika", "Yonetim");
        }
        public IActionResult Arge()
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
        public async Task<IActionResult> Arge(Arge arge)
        {
            if (ModelState.IsValid)
            {
                if (arge.Arge_Resim != null)
                {
                    arge.Arge_Resim_Yol = await _imageUploadHelper.Upload(arge.Arge_Resim, "/Resimler/Arge/");
                }

                _argeservice.TAdd(arge);
            }

            return RedirectToAction("Arge", "Yonetim");
        }
        public IActionResult ArgeDuzenle(int id)
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
            var argeduzenlenecek = _argeservice.TGetById(id);
            return View(argeduzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> ArgeDuzenle(Arge arge)
        {
            if (ModelState.IsValid)
            {
                if (arge.Arge_Resim != null)
                {
                    _imageUploadHelper.Delete("/Resimler/Arge/", arge.Arge_Resim_Yol);
                    arge.Arge_Resim_Yol = await _imageUploadHelper.Upload(arge.Arge_Resim, "/Resimler/Arge/");
                }

                _argeservice.TUpdate(arge);
            }

            return RedirectToAction("Arge", "Yonetim");
        }
        public IActionResult ArgeSil(int id)
        {
            var argesilinecek = _argeservice.TGetById(id);
            _argeservice.TDelete(argesilinecek);
            return RedirectToAction("Arge", "Yonetim");
        }

        public IActionResult ArgeGecmis()
        {
            ;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ArgeGecmis(ArgeGecmisimiz argeGecmisimiz)
        {
            if (ModelState.IsValid)
            {
                _argeGecmisimizService.TAdd(argeGecmisimiz);
            }

            return RedirectToAction("ArgeGecmis", "Yonetim");
        }
        public IActionResult ArgeGecmisDuzenle(int id)
        {

            var argeduzenlenecek = _argeGecmisimizService.TGetById(id);
            return View(argeduzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> ArgeGecmisDuzenle(ArgeGecmisimiz argeGecmisimiz)
        {
            if (ModelState.IsValid)
            {

                _argeGecmisimizService.TUpdate(argeGecmisimiz);
            }

            return RedirectToAction("ArgeGecmis", "Yonetim");
        }
        public IActionResult ArgeGecmisSil(int id)
        {
            var argeGecmissilinecek = _argeGecmisimizService.TGetById(id);
            _argeGecmisimizService.TDelete(argeGecmissilinecek);
            return RedirectToAction("ArgeGecmis", "Yonetim");
        }

        [HttpGet]
        public IActionResult EgitimVideolari()
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
            var kategoriler = _videokategoriservice.GetList();
            List<SelectListItem> egitimvideokategori = (from i in kategoriler
                                                        select new SelectListItem
                                                        {
                                                            Text = i.KategoriAdi,
                                                            Value = i.ID.ToString()
                                                        }).ToList();
            ViewBag.kategoriler = egitimvideokategori;
            return View();
        }
        [HttpPost]
        public IActionResult EgitimVideolari(EgitimVideolari egitimvideolari)
        {
            if (ModelState.IsValid)
            {
                //string wwwRootPath = _webHost.WebRootPath;
                //string filename = Path.GetFileNameWithoutExtension(egitimvideolari.Egitim_Video.FileName);
                //string extension = Path.GetExtension(egitimvideolari.Egitim_Video.FileName);
                //egitimvideolari.EgitimVideo_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                //string path = Path.Combine(wwwRootPath + "/EgitimVideolari/", filename);
                //using (var filestream = new FileStream(path, FileMode.Create))
                //{
                //    await egitimvideolari.Egitim_Video.CopyToAsync(filestream);
                //}
                _egitimvideolariservice.TAdd(egitimvideolari);
                return RedirectToAction("EgitimVideolari", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult EgitimVideoDuzenle(int id)
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
            var kategoriler = _videokategoriservice.GetList();
            List<SelectListItem> egitimvideokategori = (from i in kategoriler
                                                        select new SelectListItem
                                                        {
                                                            Text = i.KategoriAdi,
                                                            Value = i.ID.ToString()
                                                        }).ToList();
            ViewBag.kategoriler = egitimvideokategori;

            var duzenle = _egitimvideolariservice.TGetById(id);
            return View(duzenle);
        }
        [HttpPost]
        public IActionResult EgitimVideoDuzenle(EgitimVideolari egitimvideolari)
        {
            if (ModelState.IsValid)
            {
                //string wwwRootPath = _webHost.WebRootPath;
                //string filename = Path.GetFileNameWithoutExtension(egitimvideolari.Egitim_Video.FileName);
                //string extension = Path.GetExtension(egitimvideolari.Egitim_Video.FileName);
                //egitimvideolari.EgitimVideo_Yol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                //string path = Path.Combine(wwwRootPath + "/EgitimVideolari/", filename);
                //using (var filestream = new FileStream(path, FileMode.Create))
                //{
                //    await egitimvideolari.Egitim_Video.CopyToAsync(filestream);
                //}
                _egitimvideolariservice.TUpdate(egitimvideolari);
                return RedirectToAction("EgitimVideolari", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult EgitimVideoSil(int id)
        {
            var silinecek = _egitimvideolariservice.TGetById(id);
            _egitimvideolariservice.TDelete(silinecek);
            return RedirectToAction("EgitimVideolari", "Yonetim");
        }
        [HttpGet]
        public IActionResult SurumKilavuzu()
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
        public IActionResult SurumKilavuzu(SurumKilavuzu surumkilavuzu)
        {
            if (ModelState.IsValid)
            {
                _surumklavuzuservice.TAdd(surumkilavuzu);
                return RedirectToAction("SurumKilavuzu", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult SurumKilavuzuDuzenle(int id)
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
            var surumkilavuzuduzenle = _surumklavuzuservice.TGetById(id);
            return View(surumkilavuzuduzenle);
        }
        [HttpPost]
        public IActionResult SurumKilavuzuDuzenle(SurumKilavuzu surumkilavuzu)
        {
            if (ModelState.IsValid)
            {
                _surumklavuzuservice.TUpdate(surumkilavuzu);
            }
            return RedirectToAction("SurumKilavuzu", "Yonetim");
        }
        public IActionResult SurumKilavuzuSil(int id)
        {
            var surumkilavuzusil = _surumklavuzuservice.TGetById(id);
            _surumklavuzuservice.TDelete(surumkilavuzusil);
            return RedirectToAction("SurumKilavuzu", "Yonetim");
        }

        [HttpGet]
        public IActionResult SurumKilavuzIcerikEkle()
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
            var surumler = _surumklavuzuservice.GetList();
            List<SelectListItem> surumbaslik = (from i in surumler
                                                select new SelectListItem
                                                {
                                                    Text = i.SurumKilavuz_Baslik,
                                                    Value = i.SurumKilavuz_Id.ToString()
                                                }).ToList();
            ViewBag.surumler = surumbaslik;
            return View();
        }
        [HttpPost]
        public IActionResult SurumKilavuzIcerikEkle(SurumKilavuzIcerik surumKilavuzIcerik)
        {

            if (ModelState.IsValid)
            {
                _surumklavuzuicerikservice.TAdd(surumKilavuzIcerik);
                return RedirectToAction("SurumKilavuzIcerikEkle", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult SurumKilavuzIcerikDuzenle(int id)
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
            var surumler = _surumklavuzuservice.GetList();
            List<SelectListItem> surumbaslik = (from i in surumler
                                                select new SelectListItem
                                                {
                                                    Text = i.SurumKilavuz_Baslik,
                                                    Value = i.SurumKilavuz_Id.ToString()
                                                }).ToList();
            ViewBag.surumler = surumbaslik;

            var surumKilavuz = _surumklavuzuicerikservice.TGetById(id);
            return View(surumKilavuz);
        }
        [HttpPost]
        public IActionResult SurumKilavuzIcerikDuzenle(SurumKilavuzIcerik surumKilavuzIcerik)
        {
            if (ModelState.IsValid)
            {
                _surumklavuzuicerikservice.TUpdate(surumKilavuzIcerik);
                return RedirectToAction("SurumKilavuzIcerikEkle", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult SurumKilavuzIcerikSil(int id)
        {
            var surumkilavuzusil = _surumklavuzuicerikservice.TGetById(id);
            _surumklavuzuicerikservice.TDelete(surumkilavuzusil);
            return RedirectToAction("SurumKilavuzu", "Yonetim");
        }
        public IActionResult iletisim()
        {

            return View();
        }
        [HttpPost]
        public IActionResult iletisim(Iletisim iletisim)
        {
            if (ModelState.IsValid)
            {
                _iletisimservice.TAdd(iletisim);
            }
            else
            {
                return View();
            }
            return View();
        }
        public IActionResult iletisimDuzenle(int id)
        {
            var duzenlenecek = _iletisimservice.TGetById(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public IActionResult iletisimDuzenle(Iletisim iletisim)
        {
            if (ModelState.IsValid)
            {
                _iletisimservice.TUpdate(iletisim);
                return RedirectToAction("iletisim", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult iletisimSil(int id)
        {

            var silinecek = _iletisimservice.TGetById(id);
            _iletisimservice.TDelete(silinecek);
            return RedirectToAction("iletisim", "Yonetim");
        }

        public IActionResult IletisimKutusu()
        {
            var mesajlistesi = _iletisimMesajservice.GetList();
            return View(mesajlistesi);
        }
        public IActionResult IletisimDetay(int id)
        {
            var iletisimbul = _iletisimMesajservice.TGetById(id);
            return View(iletisimbul);
        }
        [HttpPost]
        public IActionResult IletisimMesajSil(List<MesajlarDto> mesaj)
        {
            Context c = new Context();
            List<MesajlarDto> silinecekMesajlar = mesaj.Where(x => x.Status == true).ToList();

            foreach (var i in silinecekMesajlar)
            {
                var Id1 = i.CheckboxId;
                var silincekmesaj = c.iletisimMesajs.Find(Id1);

                _iletisimMesajservice.TDelete(silincekmesaj);


            }
            return Ok("başarılı");
            //foreach (var i in id)
            //{
            //    var silinecek = _iletisimMesajservice.TGetById(i);
            //    _iletisimMesajservice.TDelete(silinecek);
            //}

            //return RedirectToAction("IletisimKutusu", "Yonetim");

            //var iletisimsil = iletisimMesajManager.TGetById(id);
            //iletisimMesajManager.TDelete(iletisimsil);
            //return View(iletisimsil);

        }


        public IActionResult DashBoard()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usernamesurname = c.Users.Where(x => x.UserName == username).Select(y => y.namesurname).FirstOrDefault();
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userSayisi = c.Users.Count().ToString();
            var isilanisayisi = c.isilanlaris.Count().ToString();
            var mesajsayisi = c.iletisimMesajs.Count().ToString();
            var uyeidleri = c.Users.Select(y => y.Id).ToList();
            var isverenler = c.UserRoles.Where(x => x.RoleId == (int)UserRolTypeEnum.IsVeren).Count().ToString();
            var isarayansayisi = c.UserRoles.Where(x => x.RoleId == (int)UserRolTypeEnum.IsArayan).Count().ToString();

            ViewBag.kullaniciAdi = username;
            ViewBag.adsoyad = usernamesurname;
            ViewBag.mail = usermail;
            ViewBag.uyesayisi = userSayisi;
            ViewBag.ilansayisi = isilanisayisi;
            ViewBag.mesajsayisi = mesajsayisi;
            ViewBag.isverensayisi = isverenler;
            ViewBag.isarayansayisi = isarayansayisi;
            return View();
        }
        [HttpGet]
        public IActionResult AltBilgi()
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
        public IActionResult AltBilgi(AltBilgi altBilgi)
        {
            _altBilgiService.TAdd(altBilgi);
            return RedirectToAction("AltBilgi", "Yonetim");
        }
        [HttpGet]
        public IActionResult AltBilgiDuzenle(int id)
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
            var altbilgilistele = _altBilgiService.TGetById(id);
            return View(altbilgilistele);
        }
        [HttpPost]
        public IActionResult AltBilgiDuzenle(AltBilgi altBilgi)
        {
            _altBilgiService.TUpdate(altBilgi);
            return RedirectToAction("AltBilgi", "Yonetim");
        }
        public IActionResult AltBilgiSil(int id)
        {
            var altbilgisil = _altBilgiService.TGetById(id);
            _altBilgiService.TDelete(altbilgisil);
            return RedirectToAction("AltBilgi", "Yonetim");
        }
        public IActionResult BlogAktifYap(int id)
        {
            Context c = new Context();
            var blogAktif = c.blogs.Find(id);
            blogAktif.Blog_status = true;
            c.SaveChanges();
            return RedirectToAction("BlogEkle", "Yonetim");
        }
        public IActionResult BlogPasifYap(int id)
        {
            Context c = new Context();
            var blogPasif = c.blogs.Find(id);
            blogPasif.Blog_status = false;
            c.SaveChanges();
            return RedirectToAction("BlogEkle", "Yonetim");
        }

        public IActionResult Profilim()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var namesurname = c.Users.Where(x => x.UserName == username).Select(y => y.namesurname).FirstOrDefault();
            var pass = c.Users.Where(x => x.UserName == username).Select(y => y.PasswordHash).FirstOrDefault();
            var mail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            KullaniciGuncelleDto dto = new KullaniciGuncelleDto
            {
                namesurname = namesurname,
                username = username,
                password = pass,
                email = mail

            };

            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> Profilim(KullaniciGuncelleDto model)
        {
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            user.namesurname = model.namesurname;
            user.UserName = model.username;
            user.PasswordHash = _usermanager.PasswordHasher.HashPassword(user, model.password);
            user.Email = model.email;
            IdentityResult result = await _usermanager.UpdateAsync(user);
            return RedirectToAction("Profilim", "Yonetim");
        }

        public IActionResult Logo()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Logo(Logo logo)
        {
            Context c = new Context();
            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(logo.LogoResim.FileName);
            string extension = Path.GetExtension(logo.LogoResim.FileName);
            logo.LogoYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/Resimler/Logo/", filename);
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await logo.LogoResim.CopyToAsync(filestream);
            }
            c.Logos.Add(logo);
            c.SaveChanges();
            return RedirectToAction("Logo", "Yonetim");
        }
        public IActionResult LogoDuzenle(int id)
        {
            Context c = new Context();
            var logo = c.Logos.Find(id);
            return View(logo);
        }
        [HttpPost]
        public async Task<IActionResult> LogoDuzenle(Logo logo)
        {
            Context c = new Context();
            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(logo.LogoResim.FileName);
            string extension = Path.GetExtension(logo.LogoResim.FileName);
            logo.LogoYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/Resimler/Logo/", filename);
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await logo.LogoResim.CopyToAsync(filestream);
            }
            c.Logos.Update(logo);
            c.SaveChanges();
            return RedirectToAction("Logo", "Yonetim");
        }

        public IActionResult LogoSil(int id)
        {
            Context c = new Context();
            var logos = c.Logos.Find(id);
            c.Logos.Remove(logos);
            c.SaveChanges();
            return RedirectToAction("Logo", "Yonetim");
        }
        public IActionResult LogoAktifYap(int id)
        {
            Context c = new Context();
            var logo = c.Logos.Find(id);
            logo.Status = true;
            c.SaveChanges();
            return RedirectToAction("Logo", "Yonetim");
        }
        public IActionResult LogoPasifYap(int id)
        {
            Context c = new Context();
            var logo = c.Logos.Find(id);
            logo.Status = false;
            c.SaveChanges();
            return RedirectToAction("Logo", "Yonetim");
        }
        [HttpGet]
        public IActionResult EgitimVideoKategoriEkle()
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
        public async Task<IActionResult> EgitimVideoKategoriEkle(VideoKategori video)
        {
            if (ModelState.IsValid)
            {
                if (video.KategoriResim != null)
                {
                    video.KategoriResimYol = await _imageUploadHelper.Upload(video.KategoriResim, "/Resimler/VideoKategori/");
                }

                _videokategoriservice.TAdd(video);
            }


            return RedirectToAction("EgitimVideoKategoriEkle", "Yonetim");
        }
        [HttpGet]
        public IActionResult EgitimVideoKategoriDuzenle(int id)
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
            var kategorigonder = _videokategoriservice.TGetById(id);
            return View(kategorigonder);
        }
        [HttpPost]
        public async Task<IActionResult> EgitimVideoKategoriDuzenle(VideoKategori videokategori)
        {
            if (ModelState.IsValid)
            {
                if (videokategori.KategoriResim != null)
                {
                    _imageUploadHelper.Delete("/Resimler/VideoKategori/", videokategori.KategoriResimYol);
                    videokategori.KategoriResimYol = await _imageUploadHelper.Upload(videokategori.KategoriResim, "/Resimler/VideoKategori/");
                }

                _videokategoriservice.TUpdate(videokategori);
            }

            return RedirectToAction("EgitimVideoKategoriEkle", "Yonetim");
        }
        public IActionResult EgitimVideoKategoriSil(int id)
        {
            var kategori = _videokategoriservice.TGetById(id);
            _videokategoriservice.TDelete(kategori);
            return RedirectToAction("EgitimVideoKategoriEkle", "Yonetim");
        }


        //[HttpGet]
        //public IActionResult DestekKategoriEkle()
        //{
        //    Context c = new Context();
        //    var diller = c.dilTablosus.ToList();
        //    List<SelectListItem> dil = (from i in diller
        //                                select new SelectListItem
        //                                {
        //                                    Text = i.DilAdi,
        //                                    Value = i.Id.ToString()
        //                                }).ToList();
        //    ViewBag.dil = dil;
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult DestekKategoriEkle(DestekPortaliIletisimKategori DestekKategori)
        //{
        //    _destekportalikategoriservice.TAdd(DestekKategori);
        //    return RedirectToAction("DestekKategoriEkle", "Yonetim");
        //}
        //public IActionResult DestekKategoriDuzenle(int id)
        //{
        //    Context c = new Context();
        //    var diller = c.dilTablosus.ToList();
        //    List<SelectListItem> dil = (from i in diller
        //                                select new SelectListItem
        //                                {
        //                                    Text = i.DilAdi,
        //                                    Value = i.Id.ToString()
        //                                }).ToList();
        //    ViewBag.dil = dil;
        //    var duzenlenecek = _destekportalikategoriservice.TGetById(id);
        //    return View(duzenlenecek);
        //}
        //[HttpPost]
        //public IActionResult DestekKategoriDuzenle(DestekPortaliIletisimKategori DestekKategori)
        //{
        //    _destekportalikategoriservice.TUpdate(DestekKategori);
        //    return RedirectToAction("DestekKategoriEkle", "Yonetim");
        //}
        //public IActionResult DestekKategoriSil(int id)
        //{
        //    var silinecek = _destekportalikategoriservice.TGetById(id);
        //    _destekportalikategoriservice.TDelete(silinecek);
        //    return RedirectToAction("DestekKategoriEkle", "Yonetim");
        //}


        public IActionResult AnasayfaMenu()
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
        public IActionResult AnasayfaMenu(AnasayfaMenu menu)
        {
            if (ModelState.IsValid)
            {
                _anasayfamenuservice.TAdd(menu);
                return RedirectToAction("AnasayfaMenu", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult AnasayfaMenuDuzenle(int id)
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

            var menu = _anasayfamenuservice.TGetById(id);

            return View(menu);

        }
        [HttpPost]
        public IActionResult AnasayfaMenuDuzenle(AnasayfaMenu menu)
        {
            if (ModelState.IsValid)
            {
                _anasayfamenuservice.TUpdate(menu);
                return RedirectToAction("AnasayfaMenu", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult AnasayfaMenuSil(int id)
        {
            var menu = _anasayfamenuservice.TGetById(id);
            _anasayfamenuservice.TDelete(menu);
            return RedirectToAction("AnasayfaMenu", "Yonetim");

        }


        public IActionResult AnasayfaAltMenu()
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
            var menuler = _anasayfamenuservice.GetList();
            List<SelectListItem> menulerlistesi = (from x in menuler
                                                   select new SelectListItem
                                                   {
                                                       Text = x.MenuIsim,
                                                       Value = x.Id.ToString()
                                                   }).ToList();

            ViewBag.menulistesi = menulerlistesi;
            return View();
        }
        [HttpPost]
        public IActionResult AnasayfaAltMenu(AnasayfaAltMenu menu)
        {
            if (ModelState.IsValid)
            {
                _anasayfaAltmenuservice.TAdd(menu);
                return RedirectToAction("AnasayfaAltMenu", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult AnasayfaAltMenuDuzenle(int id)
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
            var menuler = _anasayfamenuservice.GetList();
            List<SelectListItem> menulerlistesi = (from x in menuler
                                                   select new SelectListItem
                                                   {
                                                       Text = x.MenuIsim,
                                                       Value = x.Id.ToString()
                                                   }).ToList();

            ViewBag.menulistesi = menulerlistesi;
            var menu = _anasayfaAltmenuservice.TGetById(id);

            return View(menu);

        }
        [HttpPost]
        public IActionResult AnasayfaAltMenuDuzenle(AnasayfaAltMenu menu)
        {
            if (ModelState.IsValid)
            {
                _anasayfaAltmenuservice.TUpdate(menu);
                return RedirectToAction("AnasayfaAltMenu", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult AnasayfaAltMenuSil(int id)
        {
            var menu = _anasayfaAltmenuservice.TGetById(id);
            _anasayfaAltmenuservice.TDelete(menu);
            return RedirectToAction("AnasayfaAltMenu", "Yonetim");

        }
        public IActionResult DestekPortaliMesaj()
        {
            Context c = new Context();
            var msj = c.destekIletisims.ToList();
            return View(msj);
        }
        public IActionResult DestekMesajSil(int id)
        {
            Context c = new Context();
            var msjbul = c.destekIletisims.Find(id);
            var msjsil = c.destekIletisims.Remove(msjbul);
            c.SaveChanges();
            return RedirectToAction("DestekPortaliMesaj", "Yonetim");
        }

        public IActionResult HakkimizdaGuncelBilgiler()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HakkimizdaGuncelBilgiler(HakkimizdaGuncelBilgiler hakkimizda)
        {
            if (ModelState.IsValid)
            {
                _hakkimizdaGuncelBilgilerservice.TAdd(hakkimizda);
                return RedirectToAction("HakkimizdaGuncelBilgiler", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult HakkimizdaGuncelBilgilerDuzenle(int id)
        {
            var bilgi = _hakkimizdaGuncelBilgilerservice.TGetById(id);
            return View(bilgi);
        }
        [HttpPost]
        public IActionResult HakkimizdaGuncelBilgilerDuzenle(HakkimizdaGuncelBilgiler hakkimizda)
        {
            if (ModelState.IsValid)
            {
                _hakkimizdaGuncelBilgilerservice.TUpdate(hakkimizda);
                return RedirectToAction("HakkimizdaGuncelBilgiler", "Yonetim");
            }
            else
            {
                return View();
            }
        }
        public IActionResult HakkimizdaGuncelBilgilerSil(int id)
        {
            var bilgi = _hakkimizdaGuncelBilgilerservice.TGetById(id);
            _hakkimizdaGuncelBilgilerservice.TDelete(bilgi);
            return RedirectToAction("HakkimizdaGuncelBilgiler", "Yonetim");
        }

        public IActionResult IsIlanlariListele()
        {
            Context c = new Context();
            var isilanlari = c.isilanlaris.Where(x => x.Status == false).Include(x => x.AppUser).ToList();
            return View(isilanlari);
        }
        public IActionResult IsIlaniAktifYap(int id)
        {
            Context c = new Context();
            var isilani = c.isilanlaris.Find(id);
            isilani.Status = true;
            c.SaveChanges();
            return RedirectToAction("IsIlanlariListele", "Yonetim");
        }

        public IActionResult MailBulteni()
        {
            return View();
        }
        public IActionResult MailBulteniSil(int id)
        {
            Context context = new Context();
            var mailBul = context.MailBultenis.Find(id);
            context.MailBultenis.Remove(mailBul);
            context.SaveChanges();
            return RedirectToAction("MailBulteni", "Yonetim");
        }

        public IActionResult SosyalMedya()
        {
            Context c = new Context();
            var paylasimlar = c.sosyalMedyaPaylasims.FirstOrDefault();
            return View(paylasimlar);
        }
        [HttpPost]
        public IActionResult SosyalMedya(SosyalMedyaPaylasim paylasim)
        {
            Context c = new Context();
            c.sosyalMedyaPaylasims.Update(paylasim);
            c.SaveChanges();
            return RedirectToAction("SosyalMedya", "Yonetim");
        }

        public IActionResult KullaniciKlavuzuMenu()
        {
            Context c = new Context();
            var menuler = c.KMenus.ToList();
            List<SelectListItem> menu = (from i in menuler
                                         select new SelectListItem
                                         {
                                             Text = i.MenuName,
                                             Value = i.Id.ToString()
                                         }).ToList();
            ViewBag.Menuler = menu;
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
        public IActionResult KullaniciKlavuzuMenu(KMenu menu)
        {
            _menuservice.TAdd(menu);
            return RedirectToAction("KullaniciKlavuzuMenu", "Yonetim");
        }
        public IActionResult KullaniciKlavuzuIcerikEkle()
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
            //KullaniciKlavuzuIcerik icerik = new KullaniciKlavuzuIcerik();


            //var menuler = c.KMenus.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KullaniciKlavuzuIcerikEkle(KullaniciKlavuzuIcerik klavuz)
        {
            Context c = new Context();
            if (ModelState.IsValid)
            {
                c.kullaniciKlavuzuIceriks.Add(klavuz);
                c.SaveChanges();
            }
            return RedirectToAction("KullaniciKlavuzuIcerikEkle", "Yonetim");
        }

        public IActionResult KullaniciKlavuzuIcerikDuzenle(int id)
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
            var menus = c.KMenus.ToList();
            List<SelectListItem> menuler = (from x in menus
                                            select new SelectListItem
                                            {
                                                Text = x.MenuName,
                                                Value = x.Id.ToString()
                                            }).ToList();
            ViewBag.menuler = menuler;
            var icerik = _kullaniciKlavuzuIcerikservice.TGetById(id);
            return View(icerik);
        }
        [HttpPost]
        public async Task<IActionResult> KullaniciKlavuzuIcerikDuzenle(KullaniciKlavuzuIcerik klavuz)
        {
            Context c = new Context();
            if (ModelState.IsValid)
            {
                c.kullaniciKlavuzuIceriks.Update(klavuz);
                c.SaveChanges();
                //_kullaniciKlavuzuIcerikservice.TAdd(klavuz);
                //icerik.
                //KullaniciKlavuzuIcerik icerk = new KullaniciKlavuzuIcerik
                //{
                //    Baslik = icerik.IcerikBaslik,
                //    Icerik = icerik.Icerik,
                //    KMenuId = icerik.MenuId
                //};
            }
            return RedirectToAction("KullaniciKlavuzuIcerikListesi", "Yonetim");

        }
        public IActionResult KullaniciKlavuzuIcerikListesi()
        {
            Context c = new Context();
            var icerikler = c.kullaniciKlavuzuIceriks.Where(x => x.KMenuId == x.Kmenu.Id).Include(y => y.Kmenu).ToList();
            return View(icerikler);
        }
        public IActionResult KullaniciKlavuzuIcerikSil(int id)
        {
            var silincek = _kullaniciKlavuzuIcerikservice.TGetById(id);
            _kullaniciKlavuzuIcerikservice.TDelete(silincek);
            return RedirectToAction("KullaniciKlavuzuIcerikListesi", "Yonetim");
        }
        [HttpPost]
        public async Task<IActionResult> ImageUpload(IFormFile upload)
        {
            string wwwRootPath = _webHost.WebRootPath;
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(upload.FileName) + "_" + DateTime.Now.ToString("yymmssfff");
            string extension = Path.GetExtension(upload.FileName);
            string filename = fileNameWithoutExtension + extension;
            string path = Path.Combine(wwwRootPath + "/Resimler/Ortam/", filename);
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await upload.CopyToAsync(filestream);
            }

            _ortamService.TAdd(
                new Ortam
                {
                    DosyaAdi = fileNameWithoutExtension,
                    DosyaUzanti = extension,
                    OlusturmaTarihi = DateTime.Now
                });

            return Ok(new
            {
                uploaded = 1,
                fileName = filename,
                url = "/Resimler/Ortam/" + filename
            }); ;
        }
    }
}
