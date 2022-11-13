using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SosyalMedyaPaylasim
    {
        [Key]
        public int Id { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twetter { get; set; }
    }
}
