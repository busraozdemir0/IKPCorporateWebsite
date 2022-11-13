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
    public class KullaniciKlavuzuIcerikManager:IKullaniciKlavuzuIcerikService
    {
        IKullaniciKlavuzuIcerikDal _KullaniciKlavuzuIcerikDal;

        public KullaniciKlavuzuIcerikManager(IKullaniciKlavuzuIcerikDal kullaniciKlavuzuIcerikDal)
        {
            _KullaniciKlavuzuIcerikDal = kullaniciKlavuzuIcerikDal;
        }

        public List<KullaniciKlavuzuIcerik> GetList()
        {
            return _KullaniciKlavuzuIcerikDal.GetListAll();
        }

        public List<KullaniciKlavuzuIcerik> GetList(int dilId)
        {
            return _KullaniciKlavuzuIcerikDal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(KullaniciKlavuzuIcerik t)
        {
            _KullaniciKlavuzuIcerikDal.Insert(t);
        }

        public void TDelete(KullaniciKlavuzuIcerik t)
        {
            _KullaniciKlavuzuIcerikDal.Delete(t);
        }

        public KullaniciKlavuzuIcerik TGetById(int id)
        {
            return _KullaniciKlavuzuIcerikDal.GetById(id);
        }

        public void TUpdate(KullaniciKlavuzuIcerik t)
        {
            _KullaniciKlavuzuIcerikDal.Update(t);
        }
    }
}
