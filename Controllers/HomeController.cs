using Microsoft.AspNetCore.Mvc;
using PHotoFockus.Data.Interfaces;
using PHotoFockus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllProducts _productRep;

        public HomeController(IAllProducts iAllProduct)
        {
            _productRep = iAllProduct;
        }

        public ViewResult Index()
        {
            var homeProd = new HomeViewModel
            {
                favProduct = _productRep.GetFavoriteProducts
            };
            return View(homeProd);
        }
    }
}
