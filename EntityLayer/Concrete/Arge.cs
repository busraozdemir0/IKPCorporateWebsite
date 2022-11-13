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
    public class Arge
    {
        [Key]
        public int Arge_Id { get; set; }
        public string Arge_Baslik { get; set; }
        public string Arge_Icerik { get; set; }
        public string Arge_Biz_kimiz { get; set; }
        public string Arge_Resim_Yol { get; set; }
        [NotMapped]
        public IFormFile Arge_Resim { get; set; }
        public string Arge_vizyonumuz { get; set; }
        public string Arge_Misyonumuz { get; set; }
        public string Arge_Tarihcemiz_Baslik { get; set; }
        public string Arge_Tarihcemiz_icerik { get; set; }
        public string Arge_Tarihcemiz_Resim_Yol { get; set; }
        [NotMapped]
        public IFormFile Arge_Tarihcemiz_Resim { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
        public string Arge_Alt_Baslik { get; set; }
        public string Arge_Alt_Icerik { get; set; }


    }
}
