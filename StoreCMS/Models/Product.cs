using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using StoreCMS.Models;


namespace StoreCMS.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is Required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        [Range(0, 100000)]
        public Decimal Price { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public Department Department { get; set; }

        //[Required(ErrorMessage = "BarCode Number is Required")]
        //public string BarCodeNumber { get; set; }
    }
}