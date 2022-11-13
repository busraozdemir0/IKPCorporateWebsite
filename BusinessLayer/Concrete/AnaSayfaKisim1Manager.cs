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
    public class AnaSayfaKisim1Manager : IAnaSayfaKisim1Service
    {
        IAnaSayfaKisim1Dal _anaSayfaKisim1Dal;

        public AnaSayfaKisim1Manager(IAnaSayfaKisim1Dal anaSayfaKisim1Dal)
        {
            _anaSayfaKisim1Dal = anaSayfaKisim1Dal;
        }

        public List<AnaSayfaKisim1> GetList()
        {
            return _anaSayfaKisim1Dal.GetListAll();
        }

        public List<AnaSayfaKisim1> GetList(int dilId)
        {
            return _anaSayfaKisim1Dal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(AnaSayfaKisim1 t)
        {
            _anaSayfaKisim1Dal.Insert(t);
        }

        public void TDelete(AnaSayfaKisim1 t)
        {
            _anaSayfaKisim1Dal.Delete(t);
        }

        public AnaSayfaKisim1 TGetById(int id)
        {
            return _anaSayfaKisim1Dal.GetById(id);
        }



        public void TUpdate(AnaSayfaKisim1 t)
        {
            _anaSayfaKisim1Dal.Update(t);
        }
    }
}
