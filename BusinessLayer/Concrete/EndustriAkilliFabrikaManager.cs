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
    public class EndustriAkilliFabrikaManager : IEndustriAkilliFabrikaService
    {
        IEndustriAkilliFabrikaDal _endustriakillifabrikadal;

        public EndustriAkilliFabrikaManager(IEndustriAkilliFabrikaDal endustriakillifabrikadal)
        {
            _endustriakillifabrikadal = endustriakillifabrikadal;
        }

        public List<EndustriAkilliFabrika> GetList()
        {
            return _endustriakillifabrikadal.GetListAll();
        }

        public List<EndustriAkilliFabrika> GetList(int dilId)
        {
            return _endustriakillifabrikadal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(EndustriAkilliFabrika t)
        {
            _endustriakillifabrikadal.Insert(t);
        }

        public void TDelete(EndustriAkilliFabrika t)
        {
            _endustriakillifabrikadal.Delete(t);
        }

        public EndustriAkilliFabrika TGetById(int id)
        {
            return _endustriakillifabrikadal.GetById(id);
        }

        public void TUpdate(EndustriAkilliFabrika t)
        {
            _endustriakillifabrikadal.Update(t);
        }
    }
}
