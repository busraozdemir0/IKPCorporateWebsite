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
    public class UretimTakipYonetimi
    {
        [Key]
        public int UretimTakip_id { get; set; }
        public string UretimTakip_name { get; set; }
        public string UretimTakip_icerik { get; set; }
        public string UretimTakip_Resim_Yol { get; set; }
        [NotMapped]
        public IFormFile UretimTakip_Resim { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
