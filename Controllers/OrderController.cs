using Microsoft.AspNetCore.Mvc;
using PHotoFockus.Data;
using PHotoFockus.Data.Interfaces;
using PHotoFockus.Data.models;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDBContent _appDBContent;
        private readonly IAllOrder _allOrders;
        private readonly FockusCart _shopCart;

        public OrderController(IAllOrder allOrders, FockusCart shopCart, AppDBContent appDBContent)
        {
            _allOrders = allOrders;
            _shopCart = shopCart;
            _appDBContent = appDBContent;
        }


        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shopCart.listFockusItem = _shopCart.GetFockusItem();

            if (_shopCart.listFockusItem.Count == 0)
            {
                ModelState.AddModelError("", "У вас должны быть товары");
            }

            if (ModelState.IsValid)
            {
                string body = "<p>-----</p><h2>Заказ Сделал(а)</h2> <p>Имя Фамилия: " + order.name + " " + order.surename + "</p>" + "<p>номр тел.: " + order.phone + "</p>" + "<p>-----</p>";

                for(int i = 0; i < _shopCart.listFockusItem.Count; i++){
                    body += "<h2>" + _shopCart.listFockusItem[i].product.Name + " " + _shopCart.listFockusItem[i].product.ShortDescription + "</h2>" + "<p> Цена: " + _shopCart.listFockusItem[i].product.Price.ToString() + "</p>" + "<p>" + _shopCart.listFockusItem[i].product.img + "</p>" + "<p>-----</p>";
                }

                

                // <img class="img-thumbnail" src="@Model.img" alt="@Model.Name" />

                _allOrders.CreateOrder(order);
                _shopCart.SendMail(order.email, order.name, "Новый заказ", body);
                return RedirectToAction("Complete");
            }
            
            return View(order);
        }


        public IActionResult Complete(string mail, string name, string subject)
        {
            ViewBag.Message = "Заказ успешно обработан";
            _shopCart.listFockusItem = new List<FockusCartItem> { };
            
            return View();
        }
    }
}
