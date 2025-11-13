using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.DTOs.Account
{
    public class RegisterUserDTO
    {
        [Display(Name = "")]
        [Required(ErrorMessage = "")]
        [MaxLength(200, ErrorMessage = "")]
        public string MobileNumber { get; set; }
    }
}
