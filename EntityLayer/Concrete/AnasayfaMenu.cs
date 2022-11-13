using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnasayfaMenu
    {
        [Key]
        public int Id { get; set; }
        public string MenuIsim { get; set; }
        public string? MenuUrl { get; set; }
        public List<AnasayfaAltMenu>anasayfaAltMenus { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
