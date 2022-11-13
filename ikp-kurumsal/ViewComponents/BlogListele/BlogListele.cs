using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.BlogListele
{
    public class BlogListele:ViewComponent
    {
        private readonly IBlogService _blogService;

        public BlogListele(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var bloglistesi = _blogService.GetList();
            return View(bloglistesi);
        }
    }
}
