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
    public class MusterilerimizManager : IMusterilerimizService
    {
        IMusterilerimizDal _musterilerimizDal;

        public MusterilerimizManager(IMusterilerimizDal musterilerimizDal)
        {
            _musterilerimizDal = musterilerimizDal;
        }

        public List<Musterilerimiz> GetList()
        {
            return _musterilerimizDal.GetListAll();
        }

        public List<Musterilerimiz> GetList(int dilId)
        {
            return _musterilerimizDal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(Musterilerimiz t)
        {
            _musterilerimizDal.Insert(t);
        }

        public void TDelete(Musterilerimiz t)
        {
            _musterilerimizDal.Delete(t);
        }

        public Musterilerimiz TGetById(int id)
        {
            return _musterilerimizDal.GetById(id);
        }

        public void TUpdate(Musterilerimiz t)
        {
            _musterilerimizDal.Update(t);
        }
    }
}