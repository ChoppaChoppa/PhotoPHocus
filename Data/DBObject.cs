using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PHotoFockus.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data
{
    public class DBObject
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Categories.Any())
                content.Categories.AddRange(Category.Select(content => content.Value));

            if (!content.Product.Any())
            {
                content.AddRange(
                        new Product
                        {
                            Name = "Футболка",
                            ShortDescription = "Черная",
                            LongDescription = "Черная Футболка из материала 1",
                            img = "/img/ShirtBlack.jpg",
                            Price = 500,
                            IsFavorite = true,
                            available = true,
                            Categories = Category["Вещи"]
                        },

                    new Product
                    {
                        Name = "Футболка",
                        ShortDescription = "Белая",
                        LongDescription = "Белая Футболка из материала 1",
                        img = "/img/ShirtWhite.jpg",
                        Price = 500,
                        IsFavorite = false,
                        available = true,
                        Categories = Category["Вещи"]
                    },

                    new Product
                    {
                        Name = "Ручка",
                        ShortDescription = "Синяя",
                        LongDescription = "Синяя шариковая ручка",
                        img = "/img/PenBlue.jpg",
                        Price = 15,
                        IsFavorite = true,
                        available = false,
                        Categories = Category["Канцтовары"]
                    },

                    new Product
                    {
                        Name = "Ручка",
                        ShortDescription = "Черная",
                        LongDescription = "Черная Геливая ручка",
                        img = "/img/PenBlack.jpg",
                        Price = 20,
                        IsFavorite = true,
                        available = true,
                        Categories = Category["Канцтовары"]
                    },

                    new Product
                    {
                        Name = "Картина",
                        ShortDescription = "Закат",
                        LongDescription = "Оранжевый закат",
                        img = "/img/resize.jpg",
                        Price = 20,
                        IsFavorite = true,
                        available = true,
                        Categories = Category["Канцтовары"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Categories> category;
        public static Dictionary<string, Categories> Category
        {
            get
            {
                if(category == null)
                {
                    var list = new Categories[]
                    {
                        new Categories {CategoryName = "Вещи", Description = "Вещи с изображением"},
                    new Categories {CategoryName = "Канцтовары", Description = "Ручки"}
                    };

                    category = new Dictionary<string, Categories>();

                    foreach (Categories el in list)
                        category.Add(el.CategoryName, el);
                }

                return category;
            }
        }
    }
}
