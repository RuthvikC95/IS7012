using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "Country Name")]
        public string Country_Name { get; set; }
        public ICollection<Destination> Destinations { get; set; }

    }

}

