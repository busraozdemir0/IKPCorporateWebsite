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
    public class EgitimVideolariManager : IEgitimVideolariService
    {
        IEgitimVideolariDal _egitimVideolariDal;

        public EgitimVideolariManager(IEgitimVideolariDal egitimVideolariDal)
        {
            _egitimVideolariDal = egitimVideolariDal;
        }

        public List<EgitimVideolari> GetList()
        {
            return _egitimVideolariDal.GetListAll();
        }

        public List<EgitimVideolari> GetList(int dilId)
        {
            return _egitimVideolariDal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(EgitimVideolari t)
        {
           _egitimVideolariDal.Insert(t);
        }

        public void TDelete(EgitimVideolari t)
        {
            _egitimVideolariDal.Delete(t);
        }

        public EgitimVideolari TGetById(int id)
        {
            return _egitimVideolariDal.GetById(id);
        }

        public void TUpdate(EgitimVideolari t)
        {
            _egitimVideolariDal.Update(t);
        }
    }
}
