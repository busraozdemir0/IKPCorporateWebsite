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
    public class Referanslar
    {
        [Key]
        public int Referanslar_id { get; set; }
        public string Referanslar_isim { get; set; }
        public string Referanslar_icerik { get; set; }
        public string Referanslar_resim_yol { get; set; }
        [NotMapped]
        public IFormFile Referanslar_resim { get; set; }
        public bool AnaReferansMi { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
