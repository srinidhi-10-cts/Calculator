using System.ComponentModel.DataAnnotations;

namespace ECom.UI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your User ID or Email.")]
        [Display(Name = "User ID or Email")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
