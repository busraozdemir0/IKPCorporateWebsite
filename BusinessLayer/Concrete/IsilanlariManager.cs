using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class IsilanlariManager : IisilanlariService
    {
        IisilaniDal _isilanidal;

        public IsilanlariManager(IisilaniDal isilanidal)
        {
            _isilanidal = isilanidal;
        }

        public List<isilanlari> GetList()
        {
            return _isilanidal.GetListAll();
        }

        public List<isilanlari> GetList(int dilId)
        {
            return _isilanidal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(isilanlari t)
        {
            _isilanidal.Insert(t);
        }

        public void TDelete(isilanlari t)
        {
            _isilanidal.Delete(t);
        }

        public isilanlari TGetById(int id)
        {
            return _isilanidal.GetById(id);
        }

        public void TUpdate(isilanlari t)
        {
            _isilanidal.Update(t);  
        }
    }
}
