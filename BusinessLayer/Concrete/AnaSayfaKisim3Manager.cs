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
    public class AnaSayfaKisim3Manager : IAnaSayfaKisim3Service
    {
        IAnaSayfaKisim3Dal _anaSayfaKisim3Dal;

        public AnaSayfaKisim3Manager(IAnaSayfaKisim3Dal anaSayfaKisim3Dal)
        {
            _anaSayfaKisim3Dal = anaSayfaKisim3Dal;
        }

        public List<AnaSayfaKisim3> GetList()
        {
            return _anaSayfaKisim3Dal.GetListAll();
        }

        public List<AnaSayfaKisim3> GetList(int dilId)
        {
            return _anaSayfaKisim3Dal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(AnaSayfaKisim3 t)
        {
            _anaSayfaKisim3Dal.Insert(t);
        }

        public void TDelete(AnaSayfaKisim3 t)
        {
            _anaSayfaKisim3Dal.Delete(t);
        }

        public AnaSayfaKisim3 TGetById(int id)
        {
            return _anaSayfaKisim3Dal.GetById(id);
        }



        public void TUpdate(AnaSayfaKisim3 t)
        {
            _anaSayfaKisim3Dal.Update(t);
        }
    }
}
