using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.EndustriAkilliFabrikaListele
{
    public class EndustriAkilliFabrikaListele : ViewComponent
    {
        private readonly IEndustriAkilliFabrikaService _endustriakillifabrikaservice;

        public EndustriAkilliFabrikaListele(IEndustriAkilliFabrikaService endustriakillifabrikaservice)
        {
            _endustriakillifabrikaservice = endustriakillifabrikaservice;
        }

        public IViewComponentResult Invoke()
        {
            var endustrifabrikalistesi = _endustriakillifabrikaservice.GetList();
            return View(endustrifabrikalistesi);
        }
    }
}
