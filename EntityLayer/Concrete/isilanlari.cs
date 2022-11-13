using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class isilanlari
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string IsYeriAdres { get; set; }
        
        public int AppUserId { get; set; }//ilan olusturan firma id
        public bool Status { get; set; }
        public AppUser AppUser { get; set; }
        public List<IsBasvuruTbl> IsBasvuruTbls { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
    }
}
