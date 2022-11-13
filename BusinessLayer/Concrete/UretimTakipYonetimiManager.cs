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
    public class UretimTakipYonetimiManager : IUretimTakipYonetimiService
    {
        IUretimTakipYonetimiDal _uretimtakipyonetimi;

        public UretimTakipYonetimiManager(IUretimTakipYonetimiDal uretimtakipyonetimi)
        {
            _uretimtakipyonetimi = uretimtakipyonetimi;
        }

        public List<UretimTakipYonetimi> GetList()
        {
            return _uretimtakipyonetimi.GetListAll();
        }

        public List<UretimTakipYonetimi> GetList(int dilId)
        {
            return _uretimtakipyonetimi.GetListAll(x => x.DilTablosuId == dilId);
        }

        public void TAdd(UretimTakipYonetimi t)
        {
            _uretimtakipyonetimi.Insert(t);
        }

        public void TDelete(UretimTakipYonetimi t)
        {
            _uretimtakipyonetimi.Delete(t);
        }

        public UretimTakipYonetimi TGetById(int id)
        {
            return _uretimtakipyonetimi.GetById(id);
        }

        public void TUpdate(UretimTakipYonetimi t)
        {
            _uretimtakipyonetimi.Update(t);
        }
    }
}
