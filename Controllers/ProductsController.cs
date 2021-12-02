using Microsoft.AspNetCore.Mvc;
using PHotoFockus.Data.Interfaces;
using PHotoFockus.Data.models;
using PHotoFockus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PHotoFockus.Controlers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts _AllProduct;
        private readonly IProductsCategory _AllCategories;
        private readonly IAddProduct _addProduct;

        public ProductsController(IAllProducts iAllProduct, IAddProduct addProduct, IProductsCategory iProdCat)
        {
            _AllProduct = iAllProduct;
            _AllCategories = iProdCat;
            _addProduct = addProduct;
        }

        [Route("Products/List")]
        [Route("Products/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                products = _AllProduct.Products.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("clothes", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _AllProduct.Products.Where(i => i.Categories.CategoryName.Equals("Вещи")).OrderBy(i => i.id);
                }
                else if (string.Equals("stationery", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _AllProduct.Products.Where(i => i.Categories.CategoryName.Equals("Канцтовары")).OrderBy(i => i.id);
                }

                currCategory = _category;
            }

            
            var carObj = new ProductsViewModels
            {
                AllProducts = products,
                CurrCategory = currCategory
            };

            ViewBag.Title = "Страница с продуктами";

            return View(carObj);
        }

        public IActionResult AdminPass_6742()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminPass_6742(AddNewProduct add)
        {
            if (ModelState.IsValid)
            {
                _addProduct.AddProduct(add);

            }

            return View(add);
        }

        public IActionResult AddComplete()
        {
            ViewBag.Message = "Продукт Добавлен!";

            return View();
        }
    }
}
