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
    public class KaliteYonetimi
    {
        [Key]
        public int KaliteYonetimi_Id { get; set; }
        public string KaliteYonetimi_isim { get; set; }
        public string KaliteYonetimi_icerik { get; set; }
        public string KaliteYonetimi_Resim_Yol { get; set; }
        [NotMapped]
        public IFormFile KaliteYonetimi_Resim { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
