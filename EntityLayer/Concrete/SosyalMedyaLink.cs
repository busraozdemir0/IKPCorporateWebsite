using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SosyalMedyaLink
    {
        [Key]
        public int SosyalMedyaLink_id { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string FacebookLink { get; set; }
    }
}

