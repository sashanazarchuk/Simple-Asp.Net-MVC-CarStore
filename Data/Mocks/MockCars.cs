using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name="Tesla Model S Plaid",
                        shortDecs="",
                        longDesc="",
                        img="/images/Tesla.jpg",
                        price =65000,
                        isFavorite=true,
                        available=true,
                        Category=_carsCategory.AllCategories.First()
                    },

                    new Car
                    {
                        name="Audi RS Q8",
                        shortDecs="",
                        longDesc="",
                        img="/images/Audi RS Q8.jpg",
                        price =55000,
                        isFavorite=true,
                        available=true,
                        Category=_carsCategory.AllCategories.Last()
                    },

                    new Car
                    {
                        name="Porsche Cayene",
                        shortDecs="",
                        longDesc="",
                        img="/images/Porsche Cayene.jpg",
                        price =45500,
                        isFavorite=false,
                        available=true,
                        Category=_carsCategory.AllCategories.Last()
                    },

                    new Car
                    {
                        name="BMW E30",
                        shortDecs="",
                        longDesc="",
                        img="/images/BMW E30.jpg",
                        price =20500,
                        isFavorite=false,
                        available=true,
                        Category=_carsCategory.AllCategories.Last()
                    },

                    new Car
                    {
                        name="Volkswagen Arteon",
                        shortDecs="",
                        longDesc="",
                        img="/images/Volkswagen.jpg",
                        price =35000,
                        isFavorite=true,
                        available=true,
                        Category=_carsCategory.AllCategories.Last()
                    },

                    new Car
                    {
                        name="Porsche Taycan",
                        shortDecs="",
                        longDesc="",
                        img="/images/Porsche Taycan.jpg",
                        price =35500,
                        isFavorite=false,
                        available=true,
                        Category=_carsCategory.AllCategories.First()
                    }

                };
            }
        
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
