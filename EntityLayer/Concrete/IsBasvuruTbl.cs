using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class IsBasvuruTbl
    {
        [Key]
        public int Id { get; set; } 
        public int isilanlariId { get; set; }
        public isilanlari isilanlari { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
