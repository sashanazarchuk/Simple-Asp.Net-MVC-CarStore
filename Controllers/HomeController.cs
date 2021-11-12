using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController:Controller
    {
        private IAllCars _CarRep;
        public HomeController(IAllCars carRep)
        {
            _CarRep = carRep;
        }

        public ViewResult Index()
        {
            var HomeCars = new HomeViewModel
            {
                favCars = _CarRep.getFavCars
            };
            return View(HomeCars);
        }
    }
}
