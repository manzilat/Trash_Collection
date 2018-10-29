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
        public int CustomerID { get; set; }
       
        [Display(Name = "Customer Account Name")]
        public string AccountName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}