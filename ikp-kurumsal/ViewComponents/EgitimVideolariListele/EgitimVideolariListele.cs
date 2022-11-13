using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.EgitimVideolariListele
{
    public class EgitimVideolariListele : ViewComponent
    {
      

        public IViewComponentResult Invoke()
        {
            Context c = new Context();

            var videolar = c.egitimVideolaris.Where(x=>x.VideoKategoriID==x.Videokategori.ID).Include(y => y.Videokategori).ToList(); 
            //var egitimvideolist = egitimvideolarimanager.GetList();
            return View(videolar);
        }
    }
}
