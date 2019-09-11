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
        public string Destination_Name { get; set; }
        [Display(Name = "Location / Country")]
        public int LocationId { get; set; }
        public Country Location { get; set; }

        [Display(Name = " Travel Date")]
        [DataType(DataType.Date)]
        public DateTime Travel_Date { get; set; }

        [Display(Name = "Travel Duration (in days)")]
        public int? Duration { get; set; } // Nullable datatype

        [Display(Name = "Travel Cost (in $)")]
        public decimal Travel_Cost { get; set; }

        [Display(Name = "Booking Available?")]
        public bool isAvailable { get; set; }

       

        
     

    }

}
