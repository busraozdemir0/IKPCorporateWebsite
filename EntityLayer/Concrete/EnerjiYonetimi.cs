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
    public class EnerjiYonetimi
    {
        [Key]
        public int EnerjiYonetimi_Id { get; set; }
        public string EnerjiYonetimi_isim { get; set; }
        public string EnerjiYonetimi_icerik { get; set; }
        public string EnerjiYonetimi_ResimYol { get; set; }
        [NotMapped]
        public IFormFile EnerjiYonetimi_Resim { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
