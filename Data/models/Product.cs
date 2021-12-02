using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.models
{
    public class Product
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string img { get; set; }

        public ushort Price { get; set; }

        public bool IsFavorite { get; set; }

        public bool available { get; set; }

        public int CategoryID { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
