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
    public class AnaSayfaKisim4
    {
        [Key]
        public int AnaSayfaKisim4Id { get; set; }
        public string AnaSayfaBaslik4 { get; set; }
        public string AnaSayfaResim4Yol { get; set; }
        [NotMapped]
        public IFormFile AnaSayfaResim4 { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
