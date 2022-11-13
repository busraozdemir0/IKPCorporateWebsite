using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DestekPortaliIletisimKategori
    {
        [Key]
        public int Id { get; set; }
        public string Kategori_adi { get; set; }
        public List<DestekIletisim>destekIletisims { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
    }
}
