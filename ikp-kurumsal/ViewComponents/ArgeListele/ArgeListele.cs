using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ikp_kurumsal.ViewComponents.ArgeListele
{
    public class ArgeListele:ViewComponent
    {
        private readonly IArgeService _argeservice;

        public ArgeListele(IArgeService argeservice)
        {
            _argeservice = argeservice;
        }

        public IViewComponentResult Invoke()
        {
            var argelistesi = _argeservice.GetList();
            return View(argelistesi);
        }
    }
}
