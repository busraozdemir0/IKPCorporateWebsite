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
    public class Musterilerimiz
    {
        [Key]
        public int MusterilerimizId { get; set; }
        public string MusterilerimizBaslik { get; set; }
        public string Musterilerimizİcerik { get; set; }
        public string MusterilerimizYol { get; set; }
        [NotMapped]
        public IFormFile MusterilerimizResim { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
    }
}
