
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
    public class AboutProductController : Controller
    {
        public Product product;
        public AppDBContent _appDB;
        
        public AboutProductController (AppDBContent appDB)
        {
            _appDB = appDB;
        }

        public ViewResult index()
        {
            return View();
        }

        public RedirectToActionResult aboutProduct(int id)
        {
            var item = _appDB.Product.Find(id);

            if (item != null)
                product = new Product
                {
                    Name = item.Name,
                    LongDescription = item.LongDescription,
                    img = item.img,
                    Price = item.Price
                };
            
            return RedirectToAction("index");
        }
    }
}
