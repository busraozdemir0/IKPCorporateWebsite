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
    public class BakimYonetimi
    {
        [Key]
        public int BakimYonetimi_id { get; set; }
        public string BakimYonetimi_isim { get; set; }
        public string BakimYonetimi_icerik { get; set; }
        public string BakimYonetimi_Resim_Yol { get; set; }
        [NotMapped]
        public IFormFile BakimYonetimi_Resim { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
