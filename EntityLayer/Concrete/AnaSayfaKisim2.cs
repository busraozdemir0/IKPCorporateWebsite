using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnaSayfaKisim2
    {
        [Key]
        public int AnaSayfaKisim2Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Url { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
    }
}
