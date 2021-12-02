using Microsoft.EntityFrameworkCore;
using PHotoFockus.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        //public DbSet<AboutProductItem> AboutProductItem { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<FockusCartItem> FockusCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<AboutProdPage> AboutProdPage { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
    }
}
