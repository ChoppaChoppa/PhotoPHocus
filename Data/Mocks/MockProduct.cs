using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PHotoFockus.Data.Interfaces;
using PHotoFockus.Data.models;

namespace PHotoFockus.Data.Mocks
{
    public class MockProduct : IAllProducts
    {
        private readonly IProductsCategory _CategoryProduct = new MockCategory();
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                        Name = "Футболка",
                        ShortDescription = "Черная",
                        LongDescription = "Черная Футболка из материала 1",
                        img = "/img/ShirtBlack.jpg",
                        Price = 500,
                        IsFavorite = true,
                        available = true,
                        Categories = _CategoryProduct.AllCategories.First()
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
                        Categories = _CategoryProduct.AllCategories.First()
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
                        Categories = _CategoryProduct.AllCategories.Last()
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
                        Categories = _CategoryProduct.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Product> GetFavoriteProducts { get; set; }

        public Product GetObjectProduct(int ProductID)
        {
            throw new NotImplementedException();
        }
    }
}
