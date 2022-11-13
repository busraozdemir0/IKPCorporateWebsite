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
    public class KariyerManager : IKariyerService
    {
        IKariyerDal _kariyerdal;

        public KariyerManager(IKariyerDal kariyerdal)
        {
            _kariyerdal = kariyerdal;
        }

        public List<Kariyer> GetList()
        {
            return _kariyerdal.GetListAll();
        }

        public List<Kariyer> GetList(int dilId)
        {
            return _kariyerdal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(Kariyer t)
        {
            _kariyerdal.Insert(t);
        }

        public void TDelete(Kariyer t)
        {
            _kariyerdal.Delete(t);
        }

        public Kariyer TGetById(int id)
        {
            return _kariyerdal.GetById(id);
        }

        public void TUpdate(Kariyer t)
        {
            _kariyerdal.Update(t);
        }
    }
}
