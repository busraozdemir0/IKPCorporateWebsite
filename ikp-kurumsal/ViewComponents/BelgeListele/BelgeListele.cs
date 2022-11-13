using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.BelgeListele
{
    public class BelgeListele:ViewComponent
    {
        private readonly IBelgelerService _belgelerservice;

        public BelgeListele(IBelgelerService belgelerservice)
        {
            _belgelerservice = belgelerservice;
        }

        public IViewComponentResult Invoke()
        {
            List<Belgeler> belgelers;
            using (Context context=new Context() )
            {
                belgelers=context.belgelers.Include(x=>x.BelgeKategori).ToList();
            }

            return View(belgelers);
        }
    }
}
