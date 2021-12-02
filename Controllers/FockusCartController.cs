using Microsoft.AspNetCore.Mvc;
using PHotoFockus.Data;
using PHotoFockus.Data.Interfaces;
using PHotoFockus.Data.models;
using PHotoFockus.Data.Repository;
using PHotoFockus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Controllers
{
    public class FockusCartController : Controller
    {
        private readonly IAllProducts _prodRep;
        private readonly FockusCart _fockusCart;
        private readonly AppDBContent _appDBContent;

        public int ID { get; set; }

        public FockusCartController(IAllProducts prodRep, FockusCart fockusCart, AppDBContent appDBContent)
        {
            _prodRep = prodRep;
            _fockusCart = fockusCart;
            _appDBContent = appDBContent;
        }

        public ViewResult Index()
        {
            var Items = _fockusCart.GetFockusItem();
            _fockusCart.listFockusItem = Items;

            var obj = new FockusCartViewModels
            {
                fockusCart = _fockusCart
            };

            return View(obj);
        }

        public ViewResult AboutProduct(int id)
        {
            var AboutProdItem = _appDBContent.Product.Find(id);

            _fockusCart._aboutProd = AboutProdItem;

            var obj = new FockusCartViewModels
            {
                fockusCart = _fockusCart
            };

            return View(obj);
        }

        public RedirectToActionResult aboutProd(int id)
        {
            ID = id;
            var item = _prodRep.Products.FirstOrDefault(i => i.id == id);

            if (item != null)
            {
                _fockusCart.AboutProduct(item);
            }

            return RedirectToAction("AboutProduct");
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _prodRep.Products.FirstOrDefault(i => i.id == id);

            if (item != null)
            {
                _fockusCart.AddToCart(item);
            }

            return RedirectToAction("index");
        }

        public RedirectToActionResult removeToCart(int id)
        {
            _fockusCart.RemoveToCart(id);
            return RedirectToAction("index");
        }

        public RedirectToActionResult removeToCartAll()
        {
            _fockusCart.RemoveToCartAll();

            return RedirectToAction("index", "Home");
        }
    }
}