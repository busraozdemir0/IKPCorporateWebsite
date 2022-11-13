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
    public class ArgeManager : IArgeService
    {
        IArgeDal _argeDal;

        public ArgeManager(IArgeDal argeDal)
        {
            _argeDal = argeDal;
        }


        public List<Arge> GetList(int dilId)
        {
            
            return _argeDal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public List<Arge> GetList()
        {
            return _argeDal.GetListAll();
        }

        public void TAdd(Arge t)
        {
            _argeDal.Insert(t);
        }

        public void TDelete(Arge t)
        {
            _argeDal.Delete(t);
        }

        public Arge TGetById(int id)
        {
            return _argeDal.GetById(id);
        }

        //public Arge TGetById(int id, Expression<Func<Arge, bool>> filter)
        //{
        //    return _argeDal.GetById(id, filter);
        //}

        public void TUpdate(Arge t)
        {
            _argeDal.Update(t);
        }
    }
}
