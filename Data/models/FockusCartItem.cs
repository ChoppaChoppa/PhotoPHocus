using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.models
{
    public class FockusCartItem
    {
        public int id { get; set; }

        public int price { get; set; }

        public Product product { get; set; }

        public string FockusCartId { get; set; }
    }
}
