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
    public class BelgelerManager : IBelgelerService
    {
        IBelgelerDal _belgelerdal;

        public BelgelerManager(IBelgelerDal belgelerdal)
        {
            _belgelerdal = belgelerdal;
        }

        public List<Belgeler> GetList()
        {
            return _belgelerdal.GetListAll();
        }

        public List<Belgeler> GetList(int dilId)
        {
            return _belgelerdal.GetListAll();
        }

        public void TAdd(Belgeler t)
        {
            _belgelerdal.Insert(t);
        }

        public void TDelete(Belgeler t)
        {
            _belgelerdal.Delete(t);
        }

        public Belgeler TGetById(int id)
        {
            return _belgelerdal.GetById(id);
        }

        public void TUpdate(Belgeler t)
        {
            _belgelerdal.Update(t);
        }
    }
}
