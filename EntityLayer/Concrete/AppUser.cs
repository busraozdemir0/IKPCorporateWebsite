using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string namesurname { get; set; }
        [NotMapped]
        public List<IsBasvuruTbl> IsBasvuruTbls { get; set; }

        public isArayanBilgi isArayanBilgi { get; set; }

        public SifremiUnuttum SifremiUnuttum { get; set; }
        //public int SifremiUnuttumId { get; set; }
        
    }
}
