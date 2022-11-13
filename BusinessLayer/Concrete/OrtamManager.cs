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
    public class OrtamManager : IOrtamService
    {
        IOrtamDal _ortamDal;
        public OrtamManager(IOrtamDal ortamDal)
        {
            _ortamDal = ortamDal;
        }
        public List<Ortam> GetList(int dilId)
        {
            return _ortamDal.GetListAll();
        }

        public List<Ortam> GetList()
        {
            return _ortamDal.GetListAll();
        }

        public void TAdd(Ortam t)
        {
            _ortamDal.Insert(t);
        }

        public void TDelete(Ortam t)
        {
            _ortamDal.Delete(t);
        }

        public Ortam TGetById(int id)
        {
            return _ortamDal.GetById(id);
        }

        public void TUpdate(Ortam t)
        {
            _ortamDal.Update(t);
        }
    }
}
