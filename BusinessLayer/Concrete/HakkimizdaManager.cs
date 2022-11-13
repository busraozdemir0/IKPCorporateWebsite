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
    public class HakkimizdaManager : IHakkimizdaService
    {
        IHakkimizdaDal _hakkimizdaDal;

        public HakkimizdaManager(IHakkimizdaDal hakkimizdaDal)
        {
            _hakkimizdaDal = hakkimizdaDal;
        }

        public List<Hakkimizda> GetList()
        {
            return _hakkimizdaDal.GetListAll();
        }

        public List<Hakkimizda> GetList(int dilId)
        {
            return _hakkimizdaDal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(Hakkimizda t)
        {
            _hakkimizdaDal.Insert(t);
        }

        public void TDelete(Hakkimizda t)
        {
            _hakkimizdaDal.Delete(t);
        }

        public Hakkimizda TGetById(int id)
        {
            return _hakkimizdaDal.GetById(id);
        }

        public void TUpdate(Hakkimizda t)
        {
            _hakkimizdaDal.Update(t);
        }
    }
}
