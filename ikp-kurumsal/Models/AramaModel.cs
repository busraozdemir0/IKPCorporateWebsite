using EntityLayer.Concrete;
using System.Collections.Generic;

namespace ikp_kurumsal.Models
{
    public class AramaModel
    {
        public List<Hakkimizda> hakkimizdas { get; set; }
        public List<Kariyer> kariyers { get; set; }
        public List<Belgeler> belgelers { get; set; }
        public List<Arge> arges { get; set; }
        public List<Iletisim> ıletisims { get; set; }
        public List<UretimTakipYonetimi> uretimTakipYonetimis { get; set; }
        public List<BakimYonetimi> bakimYonetimis { get; set; }
        public List<EnerjiYonetimi> enerjiYonetimis { get; set; }
        public List<KaliteYonetimi> kaliteYonetimis { get; set; }
        public List<BarkodTakipStok> barkodTakipStoks { get; set; }
        public List<WebMobil> webMobils { get; set; }
        public List<EntegreSistem> entegreSistems { get; set; }
        public List<EndustriAkilliFabrika> endustriAkilliFabrikas { get; set; }
        public List<Referanslar> referanslars { get; set; }
        public List<Haber> habers { get; set; }
        public List<Blog> blogs { get; set; }
        public List<isilanlari> isilanlaris { get; set; }
        public List<DestekPortali> destekPortalis { get; set; }
        public List<KullaniciKlavuzuIcerik> kullaniciKlavuzuIceriks { get; set; }
        public List<SurumKilavuzu> surumKilavuzus { get; set; }
        public List<EgitimVideolari> egitimVideolaris { get; set; }
        public string AramaKey { get; set; }
    }
}
