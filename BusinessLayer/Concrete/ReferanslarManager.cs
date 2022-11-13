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
    public class ReferanslarManager : IReferanslarService
    {
        IReferanslarDal _referanslardal;

        public ReferanslarManager(IReferanslarDal referanslardal)
        {
            _referanslardal = referanslardal;
        }

		public List<Referanslar> GetAnaReferansList()
		{
			return _referanslardal.GetListAll(x=>x.AnaReferansMi==true);
		}

		public List<Referanslar> GetList()
        {
            return _referanslardal.GetListAll();
        }

        public List<Referanslar> GetList(int dilId)
        {
            return _referanslardal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(Referanslar t)
        {
            _referanslardal.Insert(t);
        }

        public void TDelete(Referanslar t)
        {
            _referanslardal.Delete(t);
        }

        public Referanslar TGetById(int id)
        {
            return _referanslardal.GetById(id);
        }

        public void TUpdate(Referanslar t)
        {
            _referanslardal.Update(t);
        }
    }
}
