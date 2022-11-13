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
    public class AnaSayfaKisim2Manager : IAnaSayfaKisim2Service
    {
        IAnaSayfaKisim2Dal _anaSayfaKisim2Dal;

        public AnaSayfaKisim2Manager(IAnaSayfaKisim2Dal anaSayfaKisim2Dal)
        {
            _anaSayfaKisim2Dal = anaSayfaKisim2Dal;
        }

        public List<AnaSayfaKisim2> GetList()
        {
            return _anaSayfaKisim2Dal.GetListAll();
        }

        public List<AnaSayfaKisim2> GetList(int dilId)
        {
            return _anaSayfaKisim2Dal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(AnaSayfaKisim2 t)
        {
            _anaSayfaKisim2Dal.Insert(t);
        }

        public void TDelete(AnaSayfaKisim2 t)
        {
            _anaSayfaKisim2Dal.Delete(t);
        }

        public AnaSayfaKisim2 TGetById(int id)
        {
            return _anaSayfaKisim2Dal.GetById(id);
        }



        public void TUpdate(AnaSayfaKisim2 t)
        {
            _anaSayfaKisim2Dal.Update(t);
        }
    }
}
