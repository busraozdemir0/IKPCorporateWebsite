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
    public class ArgeGecmisimizManager : IArgeGecmisimizService
    {
        IArgeGecmisimizDal _argeGecmisimizDal;
        public ArgeGecmisimizManager(IArgeGecmisimizDal argeGecmisimizDal)
        {
            _argeGecmisimizDal = argeGecmisimizDal;
        }
        public List<ArgeGecmisimiz> GetList(int dilId)
        {
            return _argeGecmisimizDal.GetListAll();
        }

        public List<ArgeGecmisimiz> GetList()
        {
            return _argeGecmisimizDal.GetListAll();
        }

        public void TAdd(ArgeGecmisimiz t)
        {
            _argeGecmisimizDal.Insert(t);
        }

        public void TDelete(ArgeGecmisimiz t)
        {
            _argeGecmisimizDal.Delete(t);
        }

        public ArgeGecmisimiz TGetById(int id)
        {
            return _argeGecmisimizDal.GetById(id);
        }

        public void TUpdate(ArgeGecmisimiz t)
        {
            _argeGecmisimizDal.Update(t);
        }
    }
}
