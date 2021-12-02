using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.models
{
    public class AboutProd
    {
        public int id { get; set; }

        public Product product { get; set; }

        public string aboutShopCartId { get; set; }
    }
}
