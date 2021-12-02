using PHotoFockus.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.ViewModels
{
    public class ProductsViewModels
    {
        public IEnumerable<Product> AllProducts { get; set; }

        public string CurrCategory { get; set; }
    }
}
