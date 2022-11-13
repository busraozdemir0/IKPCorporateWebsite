using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AltBilgi
    {
        [Key]
        public int AltBilgiId { get; set; }
        public string Baslik2 { get; set; }
        public string AltBilgiUrlBasligi { get; set; }
        public string AltBilgiUrl { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
