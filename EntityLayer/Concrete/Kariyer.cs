using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kariyer
    {
        [Key]
        public int Kariyer_id { get; set; }
        public string Kariyer_Konu_baslik { get; set; }
        public string kariyer_konu_icerik { get; set; }
        public string Kariyer_resim_yol { get; set; }
        [NotMapped]
        public IFormFile Kariyer_resim { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
    } 
}
