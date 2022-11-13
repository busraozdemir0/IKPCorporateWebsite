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
    public class iletisimManager : IiletisimService
    {
        IiletisimDal _iletisimdal;

        public iletisimManager(IiletisimDal iletisimdal)
        {
            _iletisimdal = iletisimdal;
        }

        public List<Iletisim> GetList()
        {
            return _iletisimdal.GetListAll();
        }

        public List<Iletisim> GetList(int dilId)
        {
            return _iletisimdal.GetListAll();
        }

        public void TAdd(Iletisim t)
        {
            _iletisimdal.Insert(t);
        }

        public void TDelete(Iletisim t)
        {
            _iletisimdal.Delete(t);
        }

        public Iletisim TGetById(int id)
        {
            return _iletisimdal.GetById(id);    
        }

        public void TUpdate(Iletisim t)
        {
            _iletisimdal.Update(t);
        }
    }
}
