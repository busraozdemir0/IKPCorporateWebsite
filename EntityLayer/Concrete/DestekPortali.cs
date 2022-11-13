using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DestekPortali
    {
        [Key]
        public int DestekPortali_id { get; set; }
        public string DestekPortali_Baslik { get; set; }
        public string DestekPortali_icerik { get; set; }
        public string DestekPortali_soru { get; set; }
        public string DestekPortali_cevap { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
