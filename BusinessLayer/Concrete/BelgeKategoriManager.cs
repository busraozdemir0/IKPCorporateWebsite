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
    public class BelgeKategoriManager : IBelgeKategoriService
    {
        IBelgeKategoriDal _belgeKategoriDal;
        public BelgeKategoriManager(IBelgeKategoriDal belgeKategoriDal)
        {
            _belgeKategoriDal = belgeKategoriDal;
        }
        public List<BelgeKategori> GetList()
        {
            return _belgeKategoriDal.GetListAll();
        }

        public List<BelgeKategori> GetList(int dilId)
        {
            return _belgeKategoriDal.GetListAll();
        }

        public void TAdd(BelgeKategori t)
        {
            _belgeKategoriDal.Insert(t);
        }

        public void TDelete(BelgeKategori t)
        {
            _belgeKategoriDal.Delete(t);
        }

        public BelgeKategori TGetById(int id)
        {
            return _belgeKategoriDal.GetById(id);
        }

        public void TUpdate(BelgeKategori t)
        {
            _belgeKategoriDal.Update(t);
        }
    }
}
