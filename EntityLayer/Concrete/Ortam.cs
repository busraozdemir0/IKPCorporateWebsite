using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ortam
    {
        public int Id { get; set; }
        public string DosyaAdi { get; set; }
        public string DosyaUzanti { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
    }
}
