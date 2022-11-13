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
    public class EnerjiYonetimiManager : IEnerjiYonetimiService
    {
        IEnerjiYonetimiDal _enerjiyonetimidal;

        public EnerjiYonetimiManager(IEnerjiYonetimiDal enerjiyonetimidal)
        {
            _enerjiyonetimidal = enerjiyonetimidal;
        }

        public List<EnerjiYonetimi> GetList()
        {
            return _enerjiyonetimidal.GetListAll();
        }

        public List<EnerjiYonetimi> GetList(int dilId)
        {
            return _enerjiyonetimidal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(EnerjiYonetimi t)
        {
            _enerjiyonetimidal.Insert(t);
        }

        public void TDelete(EnerjiYonetimi t)
        {
            _enerjiyonetimidal.Delete(t);
        }

        public EnerjiYonetimi TGetById(int id)
        {
           return _enerjiyonetimidal.GetById(id);
        }

        public void TUpdate(EnerjiYonetimi t)
        {
            _enerjiyonetimidal.Update(t);
        }
    }
}
