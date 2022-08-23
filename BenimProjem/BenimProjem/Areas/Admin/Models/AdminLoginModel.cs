using System.ComponentModel.DataAnnotations;

namespace BenimProjem.Areas.Admin.Models
{
    public class AdminLoginModel
    {
        [Required(ErrorMessage = "Email cannot be left blank"), MaxLength(40, ErrorMessage = "It cannot exceed 40 characters.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "Hatalı Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Your Password")]
        public string Password { get; set; }
    }
}
