using StoreCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreCMS.Models
{
    public class OrderItem
    {
        public int Quantity { get; set; }

        public Product product { get; set; }

        private Decimal subTotal;

        public OrderItem(Product prod, int qty)
        {
            this.product = prod;
            this.Quantity = qty;
        }

        public Decimal getSubtotal()
        {
            subTotal = Quantity * product.Price;
            return subTotal;
        }

        
    }
}