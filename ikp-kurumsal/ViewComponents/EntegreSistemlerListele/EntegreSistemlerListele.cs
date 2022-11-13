using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.EntegreSistemlerListele
{
    public class EntegreSistemlerListele:ViewComponent
    {
        private readonly IEntegreSistemService _entegreSistemService;

        public EntegreSistemlerListele(IEntegreSistemService entegreSistemService)
        {
            _entegreSistemService = entegreSistemService;
        }

        public IViewComponentResult Invoke()
        {
            var entegresistemlerliste = _entegreSistemService.GetList();
            return View(entegresistemlerliste);
        }
    }
}
