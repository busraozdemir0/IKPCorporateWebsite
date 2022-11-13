using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.VideoKategoriListele
{
    public class VideoKategoriListele : ViewComponent
    {
        private readonly IVideoKategoriService _videoKategoriService;

        public VideoKategoriListele(IVideoKategoriService videoKategoriService)
        {
            _videoKategoriService = videoKategoriService;
        }

        public IViewComponentResult Invoke()
        {
            var videokategorilist = _videoKategoriService.GetList();
            return View(videokategorilist);
        }
    }
}
