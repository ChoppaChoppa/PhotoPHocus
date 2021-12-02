using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PHotoFockus.Data.models;

namespace PHotoFockus.Data.Interfaces
{
    public interface IProductsCategory
    {
        IEnumerable<Categories> AllCategories { get; }
    }
}
