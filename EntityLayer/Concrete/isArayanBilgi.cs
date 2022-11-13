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
    public class isArayanBilgi
    {
        [Key]
        public int Id { get; set; }
        public string Ad_Soyad { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Cv_Yol { get; set; }
        [NotMapped]
        public IFormFile Cv { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
