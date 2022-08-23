using System.ComponentModel.DataAnnotations;

namespace BenimProjem.Models
{
    public class CheckoutViewModel
    {
        [Required(ErrorMessage = "You cannot leave this field blank.")]        
        public string City { get; set; }

        [Required(ErrorMessage = "You cannot leave this field blank.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You cannot leave this field blank.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You cannot leave this field blank.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "You cannot leave this field blank.")]
        public string Addres { get; set; }

    }
}
