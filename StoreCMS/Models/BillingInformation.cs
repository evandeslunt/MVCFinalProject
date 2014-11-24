using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StoreCMS.Models
{
    public class BillingInformation
    {
        [Required(ErrorMessage = "Type of Card Required")]
        public string TypeOfCard { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string NameOnCard { get; set; }

        [Required(ErrorMessage = "Card Number is Required")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Expiration Date is Required")]
        public DateTime ExpirationDate { get; set; }

        [Required(ErrorMessage = "Security Code is Required")]
        [StringLength(3)]
        public int SecurityCode { get; set; }
    }
}