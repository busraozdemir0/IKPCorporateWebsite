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
    public class EntegreSistemManager : IEntegreSistemService
    {
        IEntegreSistemDal _entegresistemdal;

        public EntegreSistemManager(IEntegreSistemDal entegresistemdal)
        {
            _entegresistemdal = entegresistemdal;
        }

        public List<EntegreSistem> GetList()
        {
            return _entegresistemdal.GetListAll();
        }

        public List<EntegreSistem> GetList(int dilId)
        {
            return _entegresistemdal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(EntegreSistem t)
        {
            _entegresistemdal.Insert(t);
        }

        public void TDelete(EntegreSistem t)
        {
            _entegresistemdal.Delete(t);
        }

        public EntegreSistem TGetById(int id)
        {
            return _entegresistemdal.GetById(id);
        }

        public void TUpdate(EntegreSistem t)
        {
            _entegresistemdal.Update(t);
        }
    }
}
