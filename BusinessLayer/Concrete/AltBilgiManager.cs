using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AltBilgiManager : IAltBilgiService
    {
        IAltBilgiDal _altBilgiDal;

        public AltBilgiManager(IAltBilgiDal altBilgiDal)
        {
            _altBilgiDal = altBilgiDal;
        }

        public List<AltBilgi> GetList()
        {
            return _altBilgiDal.GetListAll();
        }

        public List<AltBilgi> GetList(int dilId)
        {
            return _altBilgiDal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(AltBilgi t)
        {
            _altBilgiDal.Insert(t);
        }

        public void TDelete(AltBilgi t)
        {
            _altBilgiDal.Delete(t);
        }

        public AltBilgi TGetById(int id)
        {
            return _altBilgiDal.GetById(id);
        }

        //public AltBilgi TGetById(int id, Expression<Func<AltBilgi, bool>> filter)
        //{
        //    return _altBilgiDal.GetById(id,filter);
        //}

        public void TUpdate(AltBilgi t)
        {
            _altBilgiDal.Update(t);
        }
    }
}
