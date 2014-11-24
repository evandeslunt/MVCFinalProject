using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreCMS.Models
{
    public class ShoppingCart
    {
        
        public List<Product> allProducts { get; set; }

        public List<OrderItem> selectedItems { get; set; }

        public Decimal getGrandTotal()
        {
            decimal grandTotal = 0;
            foreach (OrderItem item in selectedItems)
            {
                grandTotal += item.getSubtotal();
            }
            return grandTotal;
        }
    }
}