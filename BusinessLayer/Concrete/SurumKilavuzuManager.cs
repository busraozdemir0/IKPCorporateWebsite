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
    public class SurumKilavuzuManager : ISurumKilavuzuService
    {
        ISurumKilavuzuDal _surumKilavuzuDal;

        public SurumKilavuzuManager(ISurumKilavuzuDal surumKilavuzuDal)
        {
            _surumKilavuzuDal = surumKilavuzuDal;
        }

        public List<SurumKilavuzu> GetList()
        {
            return _surumKilavuzuDal.GetListAll();
        }

        public List<SurumKilavuzu> GetList(int dilId)
        {
            return _surumKilavuzuDal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(SurumKilavuzu t)
        {
            _surumKilavuzuDal.Insert(t);
        }

        public void TDelete(SurumKilavuzu t)
        {
            _surumKilavuzuDal.Delete(t);
        }

        public SurumKilavuzu TGetById(int id)
        {
            return _surumKilavuzuDal.GetById(id);
        }

        public void TUpdate(SurumKilavuzu t)
        {
            _surumKilavuzuDal.Update(t);
        }
    }
}
