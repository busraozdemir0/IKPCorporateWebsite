using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnaSayfaKisim1
    {

        [Key]
        public int AnaSayfaKisim1Id { get; set; }
        public string AnaSayfaKucukBaslik1 { get; set; }
        public string AnaSayfaBuyukBaslik1 { get; set; }
        public string AnaSayfaDescription1 { get; set; }
        public string ResimYol { get; set; }
        [NotMapped]
        public IFormFile Resim { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
      


    }


}
