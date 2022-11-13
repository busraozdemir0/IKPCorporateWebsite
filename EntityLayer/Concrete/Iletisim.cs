using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class Iletisim
    {
        [Key]
        public int Iletisim_id { get; set; }
        public string Iletisim_Adresimiz { get; set; }
        public string Iletisim_Telefon_numaramiz { get; set; }
        public string Iletisim_Email_Adresimiz { get; set; }
        public string Arge_Iletisim_Adres { get; set; }
        public string Arge_Iletisim_Telefon { get; set; }
        public string Arge_Iletisim_Email { get; set; }
    }
}
