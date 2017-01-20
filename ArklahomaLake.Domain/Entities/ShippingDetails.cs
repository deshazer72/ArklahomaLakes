using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ArklahomaLake.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Please enter the first address line")]
        [Display(Name = "Line 1")]
        public string Line1 { get; set; }
        [Display(Name = "Line 2")]
        public string Line2 { get; set; }
        [Display(Name = "Line 3")]
        public string Line3 { get; set; }

        [Required (ErrorMessage = "Please enter a city name")]
        public string City { get; set; }

        [Required (ErrorMessage = "Please enter a state name")]
        public string State { get; set; }

        [Required (ErrorMessage = "Please enter zip code")]
        public string Zip { get; set; }
        
        [CreditCard]
        [Required (ErrorMessage = "You must enter a credit card number")]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        [Required (ErrorMessage = "You must enter a month")]
        [Display(Name = "Card Month")]
        public int CardMonth { get; set; }

        [Required(ErrorMessage = "You must enter a yaear")]
        [Display(Name = "Card Year")]
        public int CardYear { get; set; }

        public string EmailAddress { get; set; }


    }
}
