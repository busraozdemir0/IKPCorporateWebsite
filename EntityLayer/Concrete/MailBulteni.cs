using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class MailBulteni
    {
        [Key]
        public int MailBultenId { get; set; }
        public string KullaniciMail { get; set; }
    }
}
