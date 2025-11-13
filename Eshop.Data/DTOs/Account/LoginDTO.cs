using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.DTOs.Account
{
    public class LoginDTO
    {
        [Display(Name = "")]
        [Required(ErrorMessage = "")]
        [MaxLength(200, ErrorMessage = "")]
        public string MobileNumber { get; set; }
        public string ReturnUrl { get; set; }
    }
}
