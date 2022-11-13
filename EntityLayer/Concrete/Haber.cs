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
    public class Haber
    {
        [Key]
        public int Haber_id { get; set; }
        public string Haber_isim { get; set; }
        public string Haber_icerik { get; set; }
        public string Haber_resim_yol { get; set; }
        [NotMapped]
        public IFormFile Haber_resim { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }



    }
}
