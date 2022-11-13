using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.Areas.Uye.Models
{
    public class isilaniDto
    {
        public int Id { get; set; }
        public int kisi_id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string IsYeriAdres { get; set; }

    }
}
