using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.Areas.SY.Models
{
    public class KullaniciGuncelleDto
    {
        public int userId { get; set; }
        public string namesurname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string isarayancvyol { get; set; }
        [NotMapped]
        public IFormFile isarayancv { get; set; }
    }
}
