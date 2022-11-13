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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogdal;

        public BlogManager(IBlogDal blogdal)
        {
            _blogdal = blogdal;
        }

        public List<Blog> GetList()
        {
            return _blogdal.GetListAll();
        }

        public List<Blog> GetList(int dilId)
        {
           return _blogdal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(Blog t)
        {
            _blogdal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogdal.Delete(t);
        }

        public Blog TGetById(int id)
        {
            return _blogdal.GetById(id);
        }

        public void TUpdate(Blog t)
        {
            _blogdal.Update(t);
        }
    }
}
