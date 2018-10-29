using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trash_collection.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
       
        [Display(Name = "Customer First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Customer Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}