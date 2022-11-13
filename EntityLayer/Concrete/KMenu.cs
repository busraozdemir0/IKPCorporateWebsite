using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class KMenu
    {
        public KMenu()
        {
            KAltMenus = new HashSet<KMenu>();

        }
        [Key]
        public int Id { get; set; }
        public int? KUstMenuId { get; set; }

        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public KMenu KUstMenu { get; set; }
        public virtual ICollection<KMenu> KAltMenus { get; set; }
        public KullaniciKlavuzuIcerik KullaniciKlavuzuIcerik { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
    }
}
