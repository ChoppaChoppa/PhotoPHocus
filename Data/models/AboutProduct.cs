using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.models
{
    public class AboutProduct
    {
        public AboutProd _about { get; set; }

        private readonly AppDBContent _appDBContent;

        public AboutProduct(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        //public static AboutProduct GetAbout (IServiceProvider services)
        //{
            
        //}

        public void AddToPage(int id)
        {
            var item = _appDBContent.Product.Find(id);

            _about.product = item;
        }


    }
}
