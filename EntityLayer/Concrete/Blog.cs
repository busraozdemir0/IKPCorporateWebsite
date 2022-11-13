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
    public class Blog
    {
        [Key]
        public int Blog_id { get; set; }
        public string Blog_baslik { get; set; }
        public string Blog_icerik { get; set; }
        public string Blog_resim_yol { get; set; }
        [NotMapped]
        public IFormFile Blog_resim { get; set; }
        public bool Blog_status { get; set; }
        public int BlogKategoriID { get; set; }
        public BlogKategori BlogKategori { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
