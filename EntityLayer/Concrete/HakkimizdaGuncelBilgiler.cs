using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HakkimizdaGuncelBilgiler
    {
        [Key]
        public int Id { get; set; }
        public string UyeSayisi { get; set; }
        public string IsArayanSayisi { get; set; }
        public string IsVerenSayisi { get; set; }
        public string IsIlaniSayisi { get; set; }
        public string Baslik1 { get; set; }
        public string Icerik1 { get; set; }
        public string Baslik2 { get; set; }
        public string Icerik2 { get; set; }
        public string Baslik3 { get; set; }
        public string Icerik3 { get; set; }
        public string Baslik4 { get; set; }
        public string Icerik4 { get; set; }
    }
}
