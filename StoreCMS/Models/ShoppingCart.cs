using StoreCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreCMS.Models
{
    public class ShoppingCart
    {
        //if we can't pass the actual product object to the add to card method we can use this
        //public List<Product> allProducts { get; set; }

        public List<OrderItem> selectedItems { get; set; }

        //can also get the product ID instead of the actual Product and find the object from the 
        //allProducts List.
        public void addToCart(Product prod, int qty)
        {
            OrderItem newItem = null;
            //check to see if this item is already in the cart.
            foreach (OrderItem item in selectedItems)
            {
                if (prod.ProductId == item.product.ProductId)
                {                   
                    newItem = item;
                }
            }
            //if the item has already been selected before, add to quantity (or update, whatever we decide)
            if (!newItem.Equals(null))
            {
                //find the item
                foreach (OrderItem item in selectedItems)
                {
                    if (item.product.ProductId == newItem.product.ProductId)
                    {
                        item.Quantity += qty;
                    }
                }
            }
            else //the product is not already in the cart and newItem is null
            {
                newItem = new OrderItem(prod, qty);
                selectedItems.Add(newItem);
            }
            
        }

        public void removeFromCart(int prodId)
        {
            foreach (OrderItem item in selectedItems)
            {
                if (item.product.ProductId == prodId)
                {
                    selectedItems.Remove(item);
                }
            }
            
        }

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