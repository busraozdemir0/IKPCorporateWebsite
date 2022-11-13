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
    public class DestekPortaliKategoriManager : IDestekPortaliKategoriService
    {
        IDestekKategoriDal destekKategoriDal;

        public DestekPortaliKategoriManager(IDestekKategoriDal destekKategoriDal)
        {
            this.destekKategoriDal = destekKategoriDal;
        }

        public List<DestekPortaliIletisimKategori> GetList()
        {
            return destekKategoriDal.GetListAll();
        }

        public List<DestekPortaliIletisimKategori> GetList(int dilId)
        {
            return destekKategoriDal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(DestekPortaliIletisimKategori t)
        {
            destekKategoriDal.Insert(t);
        }

        public void TDelete(DestekPortaliIletisimKategori t)
        {
            destekKategoriDal.Delete(t);
        }


        public DestekPortaliIletisimKategori TGetById(int id)
        {
            return destekKategoriDal.GetById(id);
        }

        public void TUpdate(DestekPortaliIletisimKategori t)
        {
            destekKategoriDal.Update(t);
        }
    }
}