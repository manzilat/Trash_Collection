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

        //Vacation Schedule.
        [Display(Name = "Vacation Active, Account on hold")]
        public bool VacationPickupPause { get; set; }
        [Display(Name = "Vacation Start ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime VacationStart { get; set; }
        [Display(Name = "Vacation End ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime VacationEnd { get; set; }

        //pickup

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Pickup Start Date")]
        public DateTime PickUpDay { get; set; }
        public virtual ICollection<Calender> PickUpDates { get; set; }
        [ForeignKey("ApplicationUsers")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public ApplicationUser ApplicationUsers { get; set; }
        [Display(Name = "Last Viewed Payment")]
        public string Bill { get; set; }





        //Special Pickup.
        [Display(Name = "Special Pickup Request")]
        public bool SpecialPickupActive { get; set; }
        [Display(Name = "Special Pickup Day of Week")]
        public DayOfWeek SpecialPickupDayOfWeek { get; set; }
        [Display(Name = "Special Pickup Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SpecialPickupStart { get; set; }
        [Display(Name = "Special Pickup End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SpecialPickupEnd { get; set; }
        [Display(Name = "Price per Special Pickup")]
        public double SpecialPickupPrice { get; set; }



       

    }
}