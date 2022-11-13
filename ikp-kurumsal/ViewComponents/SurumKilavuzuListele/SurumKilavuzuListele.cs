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

namespace ikp_kurumsal.ViewComponents.SurumKilavuzuListele
{
    public class SurumKilavuzuListele : ViewComponent
    {
        private readonly ISurumKilavuzuService _surumKilavuzService;

        public SurumKilavuzuListele(ISurumKilavuzuService surumKilavuzService)
        {
            _surumKilavuzService = surumKilavuzService;
        }

        public IViewComponentResult Invoke()
        {           
            var surumkilavuzuListe = _surumKilavuzService.GetList();
            return View(surumkilavuzuListe);
        }
    }
}
