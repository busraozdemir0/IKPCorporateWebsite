using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramwork
{
    public class EfIsilanlariRepository:GenericRepository<isilanlari>,IisilaniDal
    {
        //public List<isilanlari> GetListWithisveren()
        //{
        //    using (var c = new Context())
        //    {
        //        return c.Users.Include(x => x.isilanlaris).ToList();
        //    }
        //}

    }
}
