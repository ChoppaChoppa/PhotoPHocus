using PHotoFockus.Data.Interfaces;
using PHotoFockus.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.Repository
{
    public class CategoriesRepository : IProductsCategory
    {

        private readonly AppDBContent _appDBContent;

        public CategoriesRepository(AppDBContent appDBContent)
        {
            this._appDBContent = appDBContent;
        }

        public IEnumerable<Categories> AllCategories => _appDBContent.Categories;
    }
}
