using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace PHotoFockus.Data.models
{
    public class FockusCart
    {
        public string FockusCartId { get; set; }

        public List<FockusCartItem> listFockusItem { get; set; }
        public Product _aboutProd { get; set; }


        private readonly AppDBContent _appDBContent;

        public FockusCart(AppDBContent appDBContent)
        {
            this._appDBContent = appDBContent;
        }

        public static FockusCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new FockusCart(context) { FockusCartId = shopCartId };
        }

        public void AboutProduct(Product prod)
        {
            _appDBContent.AboutProdPage.Add(new AboutProdPage
            {
                product = prod
            });

            _appDBContent.SaveChanges();
        }

        public void AddToCart(Product product)
        {
            _appDBContent.FockusCartItem.Add(new FockusCartItem
            {
                FockusCartId = this.FockusCartId,
                product = product,
                price = product.Price
            });

            _appDBContent.SaveChanges();
        }

        public void RemoveToCart(int id)
        {
            var item = _appDBContent.FockusCartItem.Find(id);
            //var itemList = listFockusItem.
            if (item != null)
            {
                _appDBContent.FockusCartItem.Remove(item);
                //listFockusItem.RemoveAt(id);
                _appDBContent.SaveChanges();

            }
        }

        public void RemoveToCartAll()
        {
            listFockusItem = new List<FockusCartItem>();
            _appDBContent.FockusCartItem.RemoveRange(_appDBContent.FockusCartItem);
            _appDBContent.SaveChanges();
        }

        public List<FockusCartItem> GetFockusItem()
        {
            //return _appDBContent.ockusCartItem.Where(c => c.FockusCartId == FockusCartId).Include(s => s.product).ToList();
            return _appDBContent.FockusCartItem.Where(c => c.FockusCartId == FockusCartId).Include(s => s.product).ToList();
        }

        public Product GetProduct (int id)
        {
            var item = _appDBContent.Product.Find(id);

            return item;
        }

        public void SendMail(string email, string name, string subject, string body){

            MailAddress formMail = new MailAddress("testing6742@mail.ru", "PHokusTeam");
            MailAddress toMail = new MailAddress(email, name);

            MailMessage msg = new MailMessage(formMail, toMail);
            msg.Subject = subject;
            msg.Body = body;
            msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
            smtp.Credentials = new NetworkCredential("testing6742@mail.ru", "Asdflkjh12");
            smtp.EnableSsl = true;
            smtp.Send(msg);
        }
       

        
    }
}