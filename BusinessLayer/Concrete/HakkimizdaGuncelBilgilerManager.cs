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
    public class HakkimizdaGuncelBilgilerManager:IHakkimizdaGuncelBilgiService
    {
        IHakkimizdaGuncelBilgiDal _hakkimizdaGuncelDal;

        public HakkimizdaGuncelBilgilerManager(IHakkimizdaGuncelBilgiDal hakkimizdaGuncelDal)
        {
            _hakkimizdaGuncelDal = hakkimizdaGuncelDal;
        }

        public List<HakkimizdaGuncelBilgiler> GetList()
        {
            return _hakkimizdaGuncelDal.GetListAll();
        }

        public List<HakkimizdaGuncelBilgiler> GetList(int dilId)
        {
            return _hakkimizdaGuncelDal.GetListAll();
        }

        public void TAdd(HakkimizdaGuncelBilgiler t)
        {
            _hakkimizdaGuncelDal.Insert(t);
        }

        public void TDelete(HakkimizdaGuncelBilgiler t)
        {
            _hakkimizdaGuncelDal.Delete(t);
        }

        public HakkimizdaGuncelBilgiler TGetById(int id)
        {
            return _hakkimizdaGuncelDal.GetById(id);
        }

        public void TUpdate(HakkimizdaGuncelBilgiler t)
        {
            _hakkimizdaGuncelDal.Update(t);
        }
    }
}
