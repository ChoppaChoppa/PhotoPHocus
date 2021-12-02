using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int productID { get; set; }
        public uint price { get; set; }
        public virtual Product product { get; set; }
        public virtual Order order { get; set; }
    }
}
