using PHotoFockus.Data.Interfaces;
using PHotoFockus.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.Repository
{
    public class OrdersRepository : IAllOrder
    {
        private readonly AppDBContent _appDBContent;
        private readonly FockusCart _shopCart;

        public OrdersRepository(AppDBContent appDBContent, FockusCart shopCart)
        {
            _appDBContent = appDBContent;
            _shopCart = shopCart;
        }
        public void CreateOrder(Order order)
        {
            order.oderTime = DateTime.Now;
            _appDBContent.Order.Add(order);
            _appDBContent.SaveChanges();

            var items = _shopCart.listFockusItem;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    productID = el.product.id,
                    orderID = order.id,
                    price = el.product.Price
                };
                _appDBContent.OrderDetail.Add(orderDetail);
            }
            _appDBContent.SaveChanges();
        }
    }
}
