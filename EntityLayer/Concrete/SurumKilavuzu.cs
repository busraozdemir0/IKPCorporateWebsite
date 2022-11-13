using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SurumKilavuzu
    {
        [Key]
        public int SurumKilavuz_Id { get; set; }
        public string SurumKilavuz_Baslik { get; set; }
        public string SurumKilavuz_Aciklama { get; set; }
        [DataType(DataType.Date)]
        public DateTime SurumKilavuz_BelgeTarihi { get; set; }
        public List<SurumKilavuzIcerik> surumKilavuzIceriks { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }


    }
}
