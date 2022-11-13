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
    public class EgitimVideolari
    {
        [Key]
        public int EgitimVideo_Id { get; set; }
        public string EgitimVideo_Baslik { get; set; }
        public string EgitimVideo_Yol { get; set; }

        public string VideoAciklama { get; set; }

        //[NotMapped]
        //public IFormFile Egitim_Video { get; set; }

        public int VideoKategoriID { get; set; }
        public VideoKategori Videokategori { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
