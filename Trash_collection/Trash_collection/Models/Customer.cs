using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        //[ForeignKey("Street Address")]
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

        //Vacation

        [Display(Name = "Vacation, Account on hold")]
        public bool VacationActivePickupPaused { get; set; }
        [Display(Name = "Vacation Start ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime VacationStart { get; set; }
        [Display(Name = "Vacation End ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime VacationEnd { get; set; }
        //pickup's


        [Display(Name = "Regular Pickup ")]
        public bool RegularPickupActive { get; set; }
        [Display(Name = "Regular Pickup Day of Week")]
        public DayOfWeek RegularPickupDayOfWeek { get; set; }
        [Display(Name = "Regular Pickup Start ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegularPickupStartDate { get; set; }
        [Display(Name = "Regular Pickup End ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegularPickupEndDate { get; set; }
        [Display(Name = "Price per Regular Pickup")]
        public double RegularPickupPrice { get; set; }



     
    }
}