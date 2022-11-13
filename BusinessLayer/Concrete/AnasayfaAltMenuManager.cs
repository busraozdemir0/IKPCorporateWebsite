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
    public class AnasayfaAltMenuManager:IAnasayfaAltMenuService
    {
        IAnasayfaAltMenuDal anasayfaAltMenu;

        public AnasayfaAltMenuManager(IAnasayfaAltMenuDal anasayfaAltMenu)
        {
            this.anasayfaAltMenu = anasayfaAltMenu;
        }

        public List<AnasayfaAltMenu> GetList()
        {
            return anasayfaAltMenu.GetListAll();
        }

        public List<AnasayfaAltMenu> GetList(int dilId)
        {
            return anasayfaAltMenu.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(AnasayfaAltMenu t)
        {
            anasayfaAltMenu.Insert(t);

        }

        public void TDelete(AnasayfaAltMenu t)
        {
            anasayfaAltMenu.Delete(t);
        }

        public AnasayfaAltMenu TGetById(int id)
        {
            return anasayfaAltMenu.GetById(id);
        }

        //public AnasayfaAltMenu TGetById(int id, Expression<Func<AnasayfaAltMenu, bool>> filter)
        //{
        //    return anasayfaAltMenu.GetById(id, filter);
        //}

        public void TUpdate(AnasayfaAltMenu t)
        {
            anasayfaAltMenu.Update(t);
        }
    }
}
