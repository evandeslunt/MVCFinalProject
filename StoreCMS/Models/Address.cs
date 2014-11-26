using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreCMS.Models
{
    public class Address
    {
        [Required(ErrorMessage = "Street Address is Required")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is Required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Zip Code is Required")]
        public string ZipCode { get; set; }
    }
}