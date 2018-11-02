using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Trash_collection.Models
{
    public class Calender
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Days { get; set; }
        public virtual ICollection<Customer> PickUpSchedule { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Pickup Start Date")]
        public DateTime PickUpDay { get; set; }
        public virtual ICollection<Calender> PickUpDates { get; set; }
       
        [Display(Name = "Last Viewed Payment")]
        public string Bill { get; set; }
        //Regular Pickup.
        [Display(Name = "Regular Pickup Active")]
        public bool RegularPickupActive { get; set; }
        [Display(Name = "Regular Pickup Day of Week")]
        public DayOfWeek RegularPickupDayOfWeek { get; set; }
        [Display(Name = "Regular Pickup Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegularPickupStartDate { get; set; }
        [Display(Name = "Regular Pickup End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegularPickupEndDate { get; set; }
        [Display(Name = "Price per Regular Pickup")]
        public double RegularPickupPrice { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}