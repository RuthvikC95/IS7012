using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class Destination
    {
        public int ID { get; set; }

        [Display(Name = " Destination Name")]
        [Required(ErrorMessage = "Please provide a name")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Invalid Input - Destination Name should have a minimum of 2 letters")] // Built-in validation rule
        public string Destination_Name { get; set; }

        [Display(Name = "Location / Country")]
        public int LocationId { get; set; }
        public Country Location { get; set; }

        public static ValidationResult isTravelDateinFuture(DateTime? TravelDate, ValidationContext context)
        {
            if (TravelDate > DateTime.Today)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Travel Date cannot be in the past");
        } // Basic Custom Validation Rule
        [Display(Name = " Travel Date")]
        [Required(ErrorMessage = "Travel Date is Required")]
        [CustomValidation(typeof(Destination), "isTravelDateinFuture")]
        [DataType(DataType.Date)]
        public DateTime Travel_Date { get; set; }

        [Display(Name = "Travel Duration (in days)")]
        [Required]
        [Range(1,100, ErrorMessage = "Travel Duration should be from 1 to 100 days")] // Built-in validation rule
        public int? Duration { get; set; } // Nullable datatype

        [Display(Name = "Travel Cost (in $)")]
        [Required]
        [Range (100,15000, ErrorMessage = "Travel Cost should be from $100 to $15000")] // Built-in validation rule
        public decimal Travel_Cost { get; set; }

        [Display(Name = "Booking Available?")]
        public bool isAvailable { get; set; }

        //[NotMapped]
        public bool bestprice
        {
            get { return (Travel_Cost < 2000);}
        }

       

        
     

    }

}
