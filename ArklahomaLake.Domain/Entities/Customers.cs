using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ArklahomaLake.Domain.Entities
{
  public class Customers
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Please enter a customer name")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Please enter a address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter a zip code")]
        [Display(Name ="Zip Code")]
        public int ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a phone number")]
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
        public string AddressUrl { get; set; }
    }
}
