using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.Areas.SY.Models
{
    public class ResetPasswordViewModel
    {
        [Display(Name = "E-Posta Adresiniz")]
        [Required(ErrorMessage = "Lütfen e-posta adresinizi boş geçmeyiniz.")]
        [EmailAddress(ErrorMessage = "Lütfen uygun formatta e-posta giriniz.")]
        public string Email { get; set; }
    }
}
