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
    public class HaberManager : IHaberService
    {
        IHaberDal _haberdal;

        public HaberManager(IHaberDal haberdal)
        {
            _haberdal = haberdal;
        }

        public List<Haber> GetList()
        {
            return _haberdal.GetListAll();
        }

        public List<Haber> GetList(int dilId)
        {
            return _haberdal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(Haber t)
        {
            _haberdal.Insert(t);
        }

        public void TDelete(Haber t)
        {
            _haberdal.Delete(t);
        }

        public Haber TGetById(int id)
        {
            return _haberdal.GetById(id);
        }

        public void TUpdate(Haber t)
        {
            _haberdal.Update(t);
        }
    }
}
