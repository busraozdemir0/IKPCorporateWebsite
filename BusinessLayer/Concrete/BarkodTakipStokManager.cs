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
    public class BarkodTakipStokManager : IBarkodTakipStokService
    {
        IBarkodTakipStokDal _barkodtakipstok;

        public BarkodTakipStokManager(IBarkodTakipStokDal barkodtakipstok)
        {
            _barkodtakipstok = barkodtakipstok;
        }

        public List<BarkodTakipStok> GetList()
        {
            return _barkodtakipstok.GetListAll();
        }

        public List<BarkodTakipStok> GetList(int dilId)
        {
            return _barkodtakipstok.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(BarkodTakipStok t)
        {
            _barkodtakipstok.Insert(t);
        }

        public void TDelete(BarkodTakipStok t)
        {
            _barkodtakipstok.Delete(t);
        }

        public BarkodTakipStok TGetById(int id)
        {
            return _barkodtakipstok.GetById(id);
        }

        public void TUpdate(BarkodTakipStok t)
        {
            _barkodtakipstok.Update(t);
        }
    }
}
