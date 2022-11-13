using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class iletisimMesaj
    {
        [Key]
        public int mesaj_id { get; set; }
        public string iletisim_Ad_Soyad { get; set; }
        public string Iletisim_Email { get; set; }
        public string Iletisim_Konu { get; set; }
        public string Iletisim_Mesaj { get; set; }
    }
}
