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
    public class KullaniciKlavuzuIcerik
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        
        public KMenu Kmenu { get; set; }
        public int KMenuId { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
    }
}
