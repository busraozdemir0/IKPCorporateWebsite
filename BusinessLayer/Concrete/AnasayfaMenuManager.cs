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
    public class AnasayfaMenuManager:IAnasayfaMenuService
    {
        IAnasayfaMenuDal _anasayfamenudal;

        public AnasayfaMenuManager(IAnasayfaMenuDal anasayfamenudal)
        {
            _anasayfamenudal = anasayfamenudal;
        }

        public List<AnasayfaMenu> GetList()
        {
            return _anasayfamenudal.GetListAll();
        }

        public List<AnasayfaMenu> GetList(int dilId)
        {
            return _anasayfamenudal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(AnasayfaMenu t)
        {
            _anasayfamenudal.Insert(t);
        }

        public void TDelete(AnasayfaMenu t)
        {
            _anasayfamenudal.Delete(t);
        }

        public AnasayfaMenu TGetById(int id)
        {
            return _anasayfamenudal.GetById(id);
        }

      

        public void TUpdate(AnasayfaMenu t)
        {
            _anasayfamenudal.Update(t);
        }
    }
}
