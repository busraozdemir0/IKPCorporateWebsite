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
    public class IsArayanBilgiManager : IisarayanBilgiService
    {
        IisArayanBilgiDal _isarayanDal;

        public IsArayanBilgiManager(IisArayanBilgiDal isarayanDal)
        {
            _isarayanDal = isarayanDal;
        }

        public List<isArayanBilgi> GetList()
        {
            return _isarayanDal.GetListAll();
        }

        public List<isArayanBilgi> GetList(int dilId)
        {
            return _isarayanDal.GetListAll();
        }

        public void TAdd(isArayanBilgi t)
        {
            _isarayanDal.Insert(t);
        }

        public void TDelete(isArayanBilgi t)
        {
            _isarayanDal.Delete(t);
        }

        public isArayanBilgi TGetById(int id)
        {
            return _isarayanDal.GetById(id);
        }

        public void TUpdate(isArayanBilgi t)
        {
            _isarayanDal.Update(t);
        }
    }
}
