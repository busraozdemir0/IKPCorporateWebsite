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
    public class MenuManager:IMenuService
    {
        IMenuDal _menudal;

        public MenuManager(IMenuDal menudal)
        {
            _menudal = menudal;
        }

        public List<KMenu> GetList()
        {
           return _menudal.GetListAll();
        }

        public List<KMenu> GetList(int dilId)
        {
            return _menudal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(KMenu t)
        {
            _menudal.Insert(t);
        }

        public void TDelete(KMenu t)
        {
            _menudal.Delete(t);
        }

        public KMenu TGetById(int id)
        {
            return _menudal.GetById(id);
        }

        public void TUpdate(KMenu t)
        {
            _menudal.Update(t);
        }
    }
}
