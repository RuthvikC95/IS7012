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

            public static ValidationResult iscountryexisting (string countryname, ValidationContext context)
            {
                 if (string.IsNullOrWhiteSpace(countryname))
                 {
                    return ValidationResult.Success;
                 }
                 var instance = context.ObjectInstance as Country;
                 if (instance == null)
                 {
                  return ValidationResult.Success;
                 }

                var dbContext = context.GetService(typeof(CoreCrudContext)) as CoreCrudContext;

                var check = dbContext.Country.FirstOrDefault(x => x.Country_Name == instance.Country_Name);

                if (check == null)
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult("The country already exists in the database");
            } // Advanced Custom Validation Rule

            [Display(Name = "Country Name")]
            [Required(ErrorMessage = "Please provide a name")]
            [StringLength(20, MinimumLength = 2, ErrorMessage = "Invalid Input - Country Name should have a minimum of 2 letters")] // Built-in validation rule
            [CustomValidation(typeof(Country), "iscountryexisting")]
            public string Country_Name { get; set; }

            public ICollection<Destination> Destinations { get; set; }

        }

    }

