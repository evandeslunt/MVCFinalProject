using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreCMS.Models
{
    public class ShoppingCart
    {
        public int Quantity { get; set; }

        public List<Product> allProducts { get; set; }

        public List<Product> selectedProducts { get; set; }


    }
}