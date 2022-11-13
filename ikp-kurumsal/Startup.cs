using BusinessLayer;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Castle.Core.Smtp;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using ikp_kurumsal.Helpers.Abstract;
using ikp_kurumsal.Helpers.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartBreadcrumbs.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ikp_kurumsal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });
            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();
            services.AddDistributedMemoryCache();
            services.AddSession(option =>
            {
                //Süre 1 dk olarak belirlendi
                option.IdleTimeout = TimeSpan.FromMinutes(1000);
            });
            services.AddMvc();
            services.AddDbContext<Context>();
            services.AddMvc();

            services.AddTransient<IisarayanBilgiService, IsArayanBilgiManager>();
            services.AddTransient<IisArayanBilgiDal, EfisArayanBilgiRepository>();
            services.AddTransient<IAnaSayfaKisim1Service, AnaSayfaKisim1Manager>();
            services.AddTransient<IAnaSayfaKisim1Dal, EfAnaSayfaKisim1Repository>();
            services.AddTransient<IAnaSayfaKisim2Service, AnaSayfaKisim2Manager>();
            services.AddTransient<IAnaSayfaKisim2Dal, EfAnaSayfaKisim2Repository>();
            services.AddTransient<IAnaSayfaKisim3Service, AnaSayfaKisim3Manager>();
            services.AddTransient<IAnaSayfaKisim3Dal, EfAnaSayfaKisim3Repository>();
            services.AddTransient<IAnaSayfaKisim4Service, AnaSayfaKisim4Manager>();
            services.AddTransient<IAnaSayfaKisim4Dal, EfAnaSayfaKisim4Repository>();
            services.AddTransient<IMenuService, MenuManager>();
            services.AddTransient<IMenuDal, EfMenuRepository>();
            services.AddTransient<IMusterilerimizService, MusterilerimizManager>();
            services.AddTransient<IMusterilerimizDal, EfMusterilerimizRepository>();
            services.AddTransient<IAnasayfaMenuService, AnasayfaMenuManager>();
            services.AddTransient<IAnasayfaMenuDal, EfAnasayfaMenuRepository>();
            services.AddTransient<IAnasayfaAltMenuService, AnasayfaAltMenuManager>();
            services.AddTransient<IAnasayfaAltMenuDal, EfAnasayfaAltMenuRepository>();
            services.AddTransient<IHakkimizdaGuncelBilgiService, HakkimizdaGuncelBilgilerManager>();
            services.AddTransient<IHakkimizdaGuncelBilgiDal, EfHakkimizdaGuncelBilgiRepository>();
            services.AddTransient<IisilanlariService, IsilanlariManager>();
            services.AddTransient<IOrtamService, OrtamManager>();
            services.AddTransient<IBelgeKategoriService, BelgeKategoriManager>();
            services.AddTransient<IArgeGecmisimizService, ArgeGecmisimizManager>();


            services.AddTransient<IisilaniDal, EfIsilanlariRepository>();
            services.AddTransient<ISurumKilavuzuService, SurumKilavuzuManager>();
            services.AddTransient<ISurumKilavuzuDal, EfSurumKilavuzuRepository>();
            services.AddTransient<IEnerjiYonetimiService, EnerjiYonetimiManager>();
            services.AddTransient<IEnerjiYonetimiDal, EfEnerjiYonetimiRepository>();
            services.AddTransient<IHakkimizdaService, HakkimizdaManager>();
            services.AddTransient<IHakkimizdaDal, EfHakkimizdaRepository>();
            services.AddTransient<IKariyerService, KariyerManager>();
            services.AddTransient<IKariyerDal, EfKariyerRepository>();
            services.AddTransient<IBelgelerService, BelgelerManager>();
            services.AddTransient<IBelgelerDal, EfBelgelerRepository>();
            services.AddTransient<IiletisimService, iletisimManager>();
            services.AddTransient<IiletisimDal, EfiletisimRepository>();
            services.AddTransient<IiletisimMesajService, iletisimMesajManager>();
            services.AddTransient<IiletisimMesajDal, EfMesajRepository>();
            services.AddTransient<IUretimTakipYonetimiService, UretimTakipYonetimiManager>();
            services.AddTransient<IUretimTakipYonetimiDal, EfUretimTakipYonetimiRepository>();
            services.AddTransient<IBakimYonetimiService, BakimYonetimiManager>();
            services.AddTransient<IBakimYonetimiDal, EfBakimYonetimiRepository>();
            services.AddTransient<IKaliteYonetimiService, KaliteYonetimiManager>();
            services.AddTransient<IKaliteYonetimiDal, EfKaliteYonetimiRepository>();
            services.AddTransient<IBarkodTakipStokService, BarkodTakipStokManager>();
            services.AddTransient<IBarkodTakipStokDal, EfBarkodTakipStokRepository>();
            services.AddTransient<IWebMobilService, WebMobileManager>();
            services.AddTransient<IWebMobilDal, EfWebMobileRepository>();
            services.AddTransient<IEntegreSistemService, EntegreSistemManager>();
            services.AddTransient<IEntegreSistemDal, EfEntegreSistemRepository>();
            services.AddTransient<IEndustriAkilliFabrikaService, EndustriAkilliFabrikaManager>();
            services.AddTransient<IEndustriAkilliFabrikaDal, EfEndustriAkilliFabrikaRepository>();
            services.AddTransient<IReferanslarService, ReferanslarManager>();
            services.AddTransient<IReferanslarDal, EfReferanslarRepository>();
            services.AddTransient<IHaberService, HaberManager>();
            services.AddTransient<IHaberDal, EfHaberRepository>();
            services.AddTransient<IBlogService, BlogManager>();
            services.AddTransient<IBlogDal, EfBlogRepository>();
            services.AddTransient<IDestekPortaliService, DestekPortaliManager>();
            services.AddTransient<IDestekPortaliDal, EfDestekPortaliRepository>();
            services.AddTransient<IArgeService, ArgeManager>();
            services.AddTransient<IArgeDal, EfArgeRepository>();
            services.AddTransient<IEgitimVideolariService, EgitimVideolariManager>();
            services.AddTransient<IEgitimVideolariDal, EfEgitimVideolariRepository>();
            services.AddTransient<ISurumKilavuzIcerikService, SurumKilavuzIcerikManager>();
            services.AddTransient<ISurumKilavuzIcerikDal, EfSurumKilavuzIcerikRepository>();
            services.AddTransient<IAltBilgiService, AltBilgiManager>();
            services.AddTransient<IAltBilgiDal, EfAltBilgiRepository>();
            services.AddTransient<IVideoKategoriService, VideoKategoriManager>();
            services.AddTransient<IVideoKategoriDal, EfVideoKategoriRepository>();
            services.AddTransient<IDestekPortaliKategoriService, DestekPortaliKategoriManager>();
            services.AddTransient<IDestekKategoriDal, EfDestekPortaliKategoriRepository>();
            services.AddTransient<IBlogKategoriService, BlogKategoriManager>();
            services.AddTransient<IBlogKategoriDal, EfBlogKategoriRepository>();
            services.AddTransient<IKullaniciKlavuzuIcerikService, KullaniciKlavuzuIcerikManager>();
            services.AddTransient<IKullaniciKlavuzuIcerikDal, EfKullaniciKlavuzuIcerikRepository>();
            services.AddTransient<IOrtamDal, EFOrtamRepository>();
            services.AddTransient<IBelgeKategoriDal, EFBelgeKategoriRepository>();
            services.AddTransient<IArgeGecmisimizDal, EfArgeGecmisimizRepository>();

            services.AddTransient<IImageUploadHelper, ImageUploadHelper>();


            //Servicesmvc.AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();
            services.AddBreadcrumbs(Assembly.GetExecutingAssembly(), options =>
            {
                options.TagName = "nav";
                options.TagClasses = "";
                options.OlClasses = "breadcrumb d-block text-center breadcrumb-light";
                options.LiClasses = "breadcrumb-item";
                options.ActiveLiClasses = "breadcrumb-item active";
            });


            services.AddIdentity<AppUser, AppRole>(x =>
            {
                x.Password.RequireLowercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireDigit = false;
                x.Password.RequireUppercase = false;
                x.Password.RequiredUniqueChars = 0;


            })
                .AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();

            services.Configure<DataProtectionTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromHours(2));

            //var emailConfig = Configuration
            //    .GetSection("EmailConfiguration")
            //    .Get<EmailConfiguration>();
            //services.AddSingleton(emailConfig);
            //services.AddScoped<IEmailSender, EmailSender>();

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/ErrorPage/Error1/";
                options.Cookie.Name = "ikp";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
                options.LoginPath = "/SY/Giris/Index/";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            // var supportedCultures = new[] { "tr", "en" };
            // var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
            //     .AddSupportedCultures(supportedCultures)
            //     .AddSupportedUICultures(supportedCultures);
            // app.UseRequestLocalization(localizationOptions);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                     name: "SY",
                     pattern: "{area:exists}/{controller=Giris}/{action=Index}/{id?}"
                     );
                endpoints.MapControllerRoute(
                     name: "Uye",
                     pattern: "{area:exists}/{controller=Giris}/{action=Index}/{id?}"
           );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");


            });
        }
    }
}
