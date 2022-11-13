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
    public class EndustriAkilliFabrika
    {
        [Key]
        public int EndustriAkilliFabrika_id { get; set; }
        public string EndustriAkilliFabrika_isim { get; set; }
        public string EndustriAkilliFabrika_icerik { get; set; }
        public string EndustriAkilliFabrika_resim_yol { get; set; }
        [NotMapped]
        public IFormFile EndustriAkilliFabrika_resim { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }


    }
}
