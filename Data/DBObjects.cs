using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
           
            if (!content.Car.Any())
            {
                content.AddRange(
                     new Car
                     {
                         name = "Tesla Model S Plaid",
                         shortDecs = "Найшвидший електромобіль",
                         longDesc = "Сучасний стильний комфортний і дуже тихий електромобіль компанії Tesla",
                         img = "/images/Tesla.jpg",
                         price = 65000,
                         isFavorite = true,
                         available = true,
                         Category = Categories["Електромобілі"]
                     },

                    new Car
                    {
                        name = "Audi RS Q8",
                        shortDecs = "Комфортний великий автомобіль",
                        longDesc = "Найпотужніший позашляховик-купе від Audi Sport: Audi RS Q8 потужністю 600 к.с. На додачу до традиційної для RS динаміки він переконує надзвичайною мінливістю вражень від керування та дизайну.",
                        img = "/images/Audi RS Q8.jpg",
                        price = 55000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Класичні автомобілі"]
                    },

                    new Car
                    {
                        name = "Porsche Cayene",
                        shortDecs = "Стильний позашляховик",
                        longDesc = "Це не звичайний спортивний автомобіль, а спортивний автомобіль для щоденного водіння",
                        img = "/images/Porsche Cayene.jpg",
                        price = 45500,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Класичні автомобілі"]
                    },

                    new Car
                    {
                        name = "BMW E30",
                        shortDecs = "Це справжня BMW",
                        longDesc = "Це перша  BMW M3 і взагалі перша BMW з якої почалась спортивна історія BMW. Найуспішніший спортивний автомобіль за всю історію M3",
                        img = "/images/BMW E30.jpg",
                        price = 20500,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Класичні автомобілі"]
                    },

                    new Car
                    {
                        name = "Volkswagen Arteon",
                        shortDecs = "Безапеляційна витонченість спорту та елегантності",
                        longDesc = "Чудовий автомобіль для щоденного водіння",
                        img = "/images/Volkswagen.jpg",
                        price = 35000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Класичні автомобілі"]
                    },

                    new Car
                    {
                        name = "Porsche Taycan",
                        shortDecs = "Спритний автомобіль",
                        longDesc = "Новий електромобіль Taycan оснащений спроектованої з нуля платформою, яка має не тільки низьким центром ваги, але і вдосконаленою підвіскою і незвичайним оформленням салону.",
                        img = "/images/Porsche Taycan.jpg",
                        price = 35500,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Електромобілі"]
                    }

               );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category==null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName = "Електромобілі", desc = "Сучасний вид транспорту"},
                        new Category{categoryName = "Класичні автомобілі", desc = "Автомобілі з двигуном внутрішнього згоряння"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName,el);
                    }
                }
                return category;
            }
        }
    }
}