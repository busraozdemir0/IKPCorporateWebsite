using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BakimYonetimiManager : IBakimYonetimiService
    {
        IBakimYonetimiDal _BakimYonetimi;

        public BakimYonetimiManager(IBakimYonetimiDal bakimYonetimi)
        {
            _BakimYonetimi = bakimYonetimi;
        }

        public List<BakimYonetimi> GetList()
        {
            return _BakimYonetimi.GetListAll();
        }

        public List<BakimYonetimi> GetList(int dilId)
        {
            return _BakimYonetimi.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(BakimYonetimi t)
        {
            _BakimYonetimi.Insert(t);
        }

        public void TDelete(BakimYonetimi t)
        {
            _BakimYonetimi.Delete(t);
        }

        public BakimYonetimi TGetById(int id)
        {
            return _BakimYonetimi.GetById(id);
        }



        public void TUpdate(BakimYonetimi t)
        {
            _BakimYonetimi.Update(t);
        }
    }
}
