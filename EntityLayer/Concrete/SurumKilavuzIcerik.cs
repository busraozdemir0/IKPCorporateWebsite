using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SurumKilavuzIcerik
    {
        [Key]
        public int SurumKilavuzIcerik_ID { get; set; }
        public string SurumKilavuzIcerik_No { get; set; }
        public string SurumKilavuzIcerik_Tanim { get; set; }
        public string SurumKilavuzIcerik_Aciklama { get; set; }
        public int SurumKilavuzuSurumKilavuz_Id { get; set; }
        public SurumKilavuzu SurumKilavuzu { get; set; }


        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }

    }
}
