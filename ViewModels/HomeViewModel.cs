using PHotoFockus.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> favProduct { get; set; }
    }
}
