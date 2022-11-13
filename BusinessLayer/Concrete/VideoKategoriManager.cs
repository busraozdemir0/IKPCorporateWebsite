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
    public class VideoKategoriManager : IVideoKategoriService
    {
        IVideoKategoriDal _ıvideokategoridal;

        public VideoKategoriManager(IVideoKategoriDal ıvideokategoridal)
        {
            _ıvideokategoridal = ıvideokategoridal;
        }

        public List<VideoKategori> GetList()
        {
            return _ıvideokategoridal.GetListAll();
        }

        public List<VideoKategori> GetList(int dilId)
        {
            return _ıvideokategoridal.GetListAll(x => x.DilTablosuId ==dilId);
        }

        public void TAdd(VideoKategori t)
        {
            _ıvideokategoridal.Insert(t);
        }

        public void TDelete(VideoKategori t)
        {
            _ıvideokategoridal.Delete(t);
        }

        public VideoKategori TGetById(int id)
        {
            return _ıvideokategoridal.GetById(id);
        }

        public void TUpdate(VideoKategori t)
        {
            _ıvideokategoridal.Update(t);
        }
    }
}
