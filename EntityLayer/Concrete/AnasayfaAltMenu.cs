using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnasayfaAltMenu
    {
        [Key]
        public int Id { get; set; }
        public  string AltMenuIsim { get; set; }
        public string AltMenuUrl { get; set; }
        public int AnasayfaMenuId { get; set; }
        public AnasayfaMenu AnasayfaMenu { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }



    }
}
