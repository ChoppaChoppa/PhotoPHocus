using Microsoft.EntityFrameworkCore;
using PHotoFockus.Data.Interfaces;
using PHotoFockus.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDBContent _appDBContent;

        public ProductRepository(AppDBContent appDBContent)
        {
            this._appDBContent = appDBContent;
        }

        public IEnumerable<Product> Products => _appDBContent.Product.Include(c => c.Categories);

        public IEnumerable<Product> GetFavoriteProducts => _appDBContent.Product.Where(p => p.IsFavorite).Include(c => c.Categories);

        public Product GetObjectProduct(int ProductID) => _appDBContent.Product.FirstOrDefault(p => p.id == ProductID);
    }
}
