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
    public class iletisimMesajManager : IiletisimMesajService
    {
        IiletisimMesajDal _iletisimMesajdal;

        public iletisimMesajManager(IiletisimMesajDal iletisimMesajdal)
        {
            _iletisimMesajdal = iletisimMesajdal;
        }

        public List<iletisimMesaj> GetList()
        {
            return _iletisimMesajdal.GetListAll();
        }

        public List<iletisimMesaj> GetList(int dilId)
        {
            return _iletisimMesajdal.GetListAll();
        }

        public void TAdd(iletisimMesaj t)
        {
            _iletisimMesajdal.Insert(t);
        }

        public void TDelete(iletisimMesaj t)
        {
            _iletisimMesajdal.Delete(t);
        }

        public iletisimMesaj TGetById(int id)
        {
            return _iletisimMesajdal.GetById(id);
        }

        public void TUpdate(iletisimMesaj t)
        {
            _iletisimMesajdal.Update(t);
        }
    }
}
