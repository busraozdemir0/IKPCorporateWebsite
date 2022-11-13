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
    public class DestekPortaliManager : IDestekPortaliService
    {
        IDestekPortaliDal _destekportalidal;

        public DestekPortaliManager(IDestekPortaliDal destekportalidal)
        {
            _destekportalidal = destekportalidal;
        }

        public List<DestekPortali> GetList()
        {
           return _destekportalidal.GetListAll();
        }

        public List<DestekPortali> GetList(int dilId)
        {
            return _destekportalidal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(DestekPortali t)
        {
            _destekportalidal.Insert(t);
        }

        public void TDelete(DestekPortali t)
        {
            _destekportalidal.Delete(t);
        }


        public DestekPortali TGetById(int id)
        {
            return _destekportalidal.GetById(id);
        }

        public void TUpdate(DestekPortali t)
        {
            _destekportalidal.Update(t);
        }
    }
}
