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
    public class WebMobileManager : IWebMobilService
    {
        IWebMobilDal _webmobildal;

        public WebMobileManager(IWebMobilDal webmobildal)
        {
            _webmobildal = webmobildal;
        }

        public List<WebMobil> GetList()
        {
            return _webmobildal.GetListAll();
        }

        public List<WebMobil> GetList(int dilId)
        {
            return _webmobildal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(WebMobil t)
        {
            _webmobildal.Insert(t);
        }

        public void TDelete(WebMobil t)
        {
            _webmobildal.Delete(t);
        }

        public WebMobil TGetById(int id)
        {
            return _webmobildal.GetById(id);
        }

        public void TUpdate(WebMobil t)
        {
            _webmobildal.Update(t);
        }
    }
}
