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
    public class Belgeler
    {
        [Key]
        public int Belge_Id { get; set; }
        public int BelgeKategoriId { get; set; }
        public string Belge_isim { get; set; }
        public string Belge_Resim_Yol { get; set; }
        [NotMapped]
        public IFormFile Belge_Resim { get; set; }
        public BelgeKategori BelgeKategori { get; set; }

    }
}
