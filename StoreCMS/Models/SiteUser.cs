using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using StoreCMS.Models;

namespace StoreCMS.Models
{
    public class SiteUser
    {
        [Required]
        public int Id { get; set; }

        //Email
        [Required(ErrorMessage = "User Name is Required")]
        [EmailAddress(ErrorMessage = "Must be a valid Email Address")]
        public EmailAddressAttribute UserName { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required]
        public Address address { get; set; }

        //password?
    }
}