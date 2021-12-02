using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PHotoFockus.Data.models;

namespace PHotoFockus.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> GetFavoriteProducts { get; }

        Product GetObjectProduct(int ProductID);
    }
}
