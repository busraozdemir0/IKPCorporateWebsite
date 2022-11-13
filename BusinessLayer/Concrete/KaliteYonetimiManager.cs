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
    public class KaliteYonetimiManager : IKaliteYonetimiService
    {
        IKaliteYonetimiDal _kaliteyonetimidal;

        public KaliteYonetimiManager(IKaliteYonetimiDal kaliteyonetimidal)
        {
            _kaliteyonetimidal = kaliteyonetimidal;
        }

        public List<KaliteYonetimi> GetList()
        {
          return _kaliteyonetimidal.GetListAll();
        }

        public List<KaliteYonetimi> GetList(int dilId)
        {
            return _kaliteyonetimidal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(KaliteYonetimi t)
        {
            _kaliteyonetimidal.Insert(t);
        }

        public void TDelete(KaliteYonetimi t)
        {
            _kaliteyonetimidal.Delete(t);
        }

        public KaliteYonetimi TGetById(int id)
        {
            return _kaliteyonetimidal.GetById(id);
        }

        public void TUpdate(KaliteYonetimi t)
        {
            _kaliteyonetimidal.Update(t);
        }
    }
}
