using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnaSayfaKisim3
    {
        [Key]
        public int AnaSayfaKisim3Id { get; set; }
        public string Baslik { get; set; }
        public string AltBaslik { get; set; }
        public string Icerik { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
    }
}
