using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PHotoFockus.Data.Interfaces;
using PHotoFockus.Data.models;

namespace PHotoFockus.Data.Mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Categories> AllCategories
        {
            get
            {
                return new List<Categories>
                {
                    new Categories {CategoryName = "Принт", Description = "Вещи с изображением"},
                    new Categories {CategoryName = "Концтовары", Description = "Концтовар"}
                };
            }
        }
    }
}
