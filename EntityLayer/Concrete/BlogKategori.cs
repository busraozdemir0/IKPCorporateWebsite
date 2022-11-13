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
    public class BlogKategori
    {
        [Key]
        public int ID { get; set; }
        public string BlogKategoriAdi { get; set; }
        public string BlogKategoriAciklamasi { get; set; }
        public string KategoriResimYol { get; set; }

        [NotMapped]
        public IFormFile KategoriResim { get; set; }
        public List<Blog> blogs { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
