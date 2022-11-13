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
    public class BarkodTakipStok
    {
        [Key]
        public int BarkodTakipStok_id { get; set; }
        public string BarkodTakipStok_isim { get; set; }
        public string BarkodTakipStok_icerik { get; set; }
        public string BarkodTakipStok_Resim_Yol { get; set; }
        [NotMapped]
        public IFormFile BarkodTakipStok_Resim { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
