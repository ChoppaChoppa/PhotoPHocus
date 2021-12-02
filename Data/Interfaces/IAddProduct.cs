using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.Interfaces
{
    public interface IAddProduct
    {
        void AddProduct(models.AddNewProduct add);
    }
}
