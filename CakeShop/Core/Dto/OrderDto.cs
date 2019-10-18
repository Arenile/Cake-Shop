using System.ComponentModel.DataAnnotations;

namespace CakeShop.Core.Dto
{
    public class OrderDto
    {


        [StringLength(255)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [StringLength(255)]
        [Display(Name = "Address Line 1")]
        [Required(ErrorMessage = "Address Line 1 is required")]
        public string AddressLine1 { get; set; }

        [StringLength(255)]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [StringLength(6)]
        [Required(ErrorMessage = "Zipcode is required")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Email Address is required")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //This code was for trying to make it possible to automatically order with a web API
        /**[StringLength(255)]
        public string CakeType { get; set; }

        public int CakeNumber { get; set; }**/ 

        //Creates the compoenent of OrderDto that holds the customer's note. Set up as a string, but note that this isn't a required form. 
        [StringLength(255)]
        [Display(Name = "Note for Order")]
        public string OrderNote { get; set; }
    }
}
