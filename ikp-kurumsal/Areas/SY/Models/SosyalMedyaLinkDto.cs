using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.Areas.SY.Models
{
    public class SosyalMedyaLinkDto
    {
        public int SosyalMedyaLink_id { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string FacebookLink { get; set; }
    }
}
