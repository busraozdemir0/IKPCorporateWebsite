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
    public class BlogKategoriManager : IBlogKategoriService
    {
        IBlogKategoriDal _blogKategoriDal;

        public BlogKategoriManager(IBlogKategoriDal blogKategoriDal)
        {
            _blogKategoriDal = blogKategoriDal;
        }

        public List<BlogKategori> GetList()
        {
            return _blogKategoriDal.GetListAll();
        }

        public List<BlogKategori> GetList(int dilId)
        {
            return _blogKategoriDal.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(BlogKategori t)
        {
            _blogKategoriDal.Insert(t);
        }

        public void TDelete(BlogKategori t)
        {
            _blogKategoriDal.Delete(t);
        }

        public BlogKategori TGetById(int id)
        {
            return _blogKategoriDal.GetById(id);
        }

        public void TUpdate(BlogKategori t)
        {
            _blogKategoriDal.Update(t);
        }
    }
}
