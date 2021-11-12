using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars IAllCars, ICarsCategory ICarsCat)
        {
            _allCars = IAllCars;
            _allCategories = ICarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars=null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("electro",category,StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Електромобілі")).OrderBy(i => i.id);
                    currCategory = "Електромобілі";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Класичні автомобілі")).OrderBy(i => i.id);
                    currCategory = "Класичні автомобілі";
                }
              
            }

            var carobj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
            };
            ViewBag.Title = "Сторінка з автомобілями";
         
            return View(carobj);
        }
        
    }
}