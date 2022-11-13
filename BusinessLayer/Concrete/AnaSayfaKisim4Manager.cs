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
    public class AnaSayfaKisim4Manager : IAnaSayfaKisim4Service
    {
        IAnaSayfaKisim4Dal _anaSayfaKisim4Dal;

        public AnaSayfaKisim4Manager(IAnaSayfaKisim4Dal anaSayfaKisim4Dal)
        {
            _anaSayfaKisim4Dal = anaSayfaKisim4Dal;
        }

        public List<AnaSayfaKisim4> GetList()
        {
            return _anaSayfaKisim4Dal.GetListAll();
        }

        public List<AnaSayfaKisim4> GetList(int dilId)
        {
            return _anaSayfaKisim4Dal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(AnaSayfaKisim4 t)
        {
            _anaSayfaKisim4Dal.Insert(t);
        }

        public void TDelete(AnaSayfaKisim4 t)
        {
            _anaSayfaKisim4Dal.Delete(t);
        }

        public AnaSayfaKisim4 TGetById(int id)
        {
            return _anaSayfaKisim4Dal.GetById(id);
        }



        public void TUpdate(AnaSayfaKisim4 t)
        {
            _anaSayfaKisim4Dal.Update(t);
        }
    }
}
