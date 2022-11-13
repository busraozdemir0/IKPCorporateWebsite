using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DestekIletisim
    {
        [Key]
        public int id { get; set; }
        public string isim { get; set; }
        public string mail { get; set; }
        public string konu { get; set; }
        public string mesaj { get; set; }
        public int DestekPortaliIletisimKategoriId { get; set; }
        public DestekPortaliIletisimKategori DestekPortaliIletisimKategori { get; set; }
    }
}
