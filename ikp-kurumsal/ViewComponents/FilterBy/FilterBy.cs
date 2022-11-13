using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.FilterBy
{
    public class FilterBy:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
