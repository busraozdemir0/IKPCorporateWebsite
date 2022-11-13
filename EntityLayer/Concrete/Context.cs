using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //UseMySQL connection string

        }


        public DbSet<Arge> arges { get; set; }
        public DbSet<BakimYonetimi> bakimYonetimis { get; set; }
        public DbSet<BarkodTakipStok> barkodTakipStoks { get; set; }
        public DbSet<Belgeler> belgelers { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<BlogKategori> blogKategoris { get; set; }
        public DbSet<DestekPortali> destekPortalis { get; set; }
        public DbSet<EndustriAkilliFabrika> endustriAkilliFabrikas { get; set; }
        public DbSet<EnerjiYonetimi> enerjiYonetimis { get; set; }
        public DbSet<EntegreSistem> entegreSistems { get; set; }
        public DbSet<Haber> habers { get; set; }
        public DbSet<Hakkimizda> hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<KaliteYonetimi> kaliteYonetimis { get; set; }
        public DbSet<Referanslar> referanslars { get; set; }
        public DbSet<UretimTakipYonetimi> uretimTakipYonetimis { get; set; }
        public DbSet<WebMobil> webMobils { get; set; }
        public DbSet<Kariyer> kariyers { get; set; }
        public DbSet<iletisimMesaj> iletisimMesajs { get; set; }
        public DbSet<EgitimVideolari> egitimVideolaris { get; set; }
        public DbSet<SurumKilavuzu> surumKilavuzus { get; set; }
        public DbSet<AnaSayfaKisim1> anaSayfaKisim1s { get; set; }
        public DbSet<AnaSayfaKisim2> anaSayfaKisim2s { get; set; }
        public DbSet<AnaSayfaKisim3> anaSayfaKisim3s { get; set; }
        public DbSet<AnaSayfaKisim4> anaSayfaKisim4s { get; set; }
        public DbSet<isilanlari> isilanlaris { get; set; }
        public DbSet<isArayanBilgi> isArayanBilgis { get; set; }
        public DbSet<IsBasvuruTbl> IsBasvuruTbls { get; set; }
        public DbSet<AltBilgi> altBilgis { get; set; }
        public virtual DbSet<KMenu> KMenus { get; set; }
		public DbSet<Logo> Logos { get; set; }
        public DbSet<Musterilerimiz> Musterilerimizs { get; set; }
        public DbSet<VideoKategori> VideoKategoris { get; set; }
        public DbSet<DestekPortaliIletisimKategori> destekPortaliIletisimKategoris { get; set; }
        public DbSet<DestekIletisim> destekIletisims { get; set; }
        public DbSet<AnasayfaMenu>anasayfaMenus { get; set; }
        public DbSet<AnasayfaAltMenu>anasayfaAltMenus { get; set; }
        public DbSet<SurumKilavuzIcerik> surumKilavuzIceriks { get; set; }
        public DbSet<HakkimizdaGuncelBilgiler> hakkimizdaGuncelBilgilers { get; set; }
        public DbSet<MailBulteni> MailBultenis { get; set; }
        public DbSet<KullaniciKlavuzuIcerik> kullaniciKlavuzuIceriks { get; set; }
        public DbSet<SosyalMedyaLink> SosyalMedyaLinks { get; set; }
        public DbSet<SifremiUnuttum> sifremiUnuttums { get; set; }
        public DbSet<SifremiUnuttumMailTut> sifremiUnuttumMailTuts { get; set; }
        public DbSet<DilTablosu> dilTablosus { get; set; }
        public DbSet<SosyalMedyaPaylasim>sosyalMedyaPaylasims { get; set; }
        public DbSet<Ortam> ortams{ get; set; }
        public DbSet<BelgeKategori> belgeKategoris{ get; set; }
        public DbSet<ArgeGecmisimiz> argeGecmisimizs { get; set; }
    }
}
