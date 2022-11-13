using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ikp_kurumsal.Areas.SY.Models
{
    public class isarayanBilgiDto
    {
        public int IsArayanId { get; set; }
        public string IsArayanCvYol { get; set; }
        [NotMapped]
        public IFormFile IsArayanCv { get; set; }
    }
}
