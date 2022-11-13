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
    public class SurumKilavuzIcerikManager : ISurumKilavuzIcerikService
    {
        ISurumKilavuzIcerikDal _surumKilavuzIcerikDal;

        public SurumKilavuzIcerikManager(ISurumKilavuzIcerikDal surumKilavuzIcerikDal)
        {
            _surumKilavuzIcerikDal = surumKilavuzIcerikDal;
        }

        public List<SurumKilavuzIcerik> GetList()
        {
            return _surumKilavuzIcerikDal.GetListAll();
        }

        public List<SurumKilavuzIcerik> GetList(int dilId)
        {
            return _surumKilavuzIcerikDal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(SurumKilavuzIcerik t)
        {
            _surumKilavuzIcerikDal.Insert(t);
        }

        public void TDelete(SurumKilavuzIcerik t)
        {
            _surumKilavuzIcerikDal.Delete(t);
        }

        public SurumKilavuzIcerik TGetById(int id)
        {
            return _surumKilavuzIcerikDal.GetById(id);
        }

        public void TUpdate(SurumKilavuzIcerik t)
        {
            _surumKilavuzIcerikDal.Update(t);
        }
    }
}
