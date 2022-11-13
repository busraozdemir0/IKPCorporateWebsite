using System.ComponentModel.DataAnnotations;

namespace ikp_kurumsal.Areas.SY.Models
{
    public class KullaniciGirisDto
    {
        [Required(ErrorMessage = "lüften kullancı adı giriniz.")]
        public string username { get; set; }

        [Required(ErrorMessage = "lütfen şifrenizi giriniz.")]
        public string password { get; set; }
    }
}
