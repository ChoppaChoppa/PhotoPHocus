using PHotoFockus.Data.Interfaces;
using PHotoFockus.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.Repository
{
    public class AddProductRepository : IAddProduct
    {
        private readonly AppDBContent _appDBContent;

        public AddProductRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public void AddProduct(AddNewProduct add)
        {
            _appDBContent.Product.Add(new Product
            {
                Name = add.Name,
                ShortDescription = add.ShortDescription,
                LongDescription = add.LongDescription,
                img = add.img,
                Price = add.Price,
                IsFavorite = true,
                available = true,
                CategoryID = add.CategoryID,
                Categories = add.Categories
            });

            _appDBContent.SaveChanges();
        }
    }
}
