using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.DTOs.Account
{
    public class MobileActivationDTO
    {
        [Display(Name = "")]
        [Required(ErrorMessage = "")]
        [MaxLength(200, ErrorMessage = "")]
        public string ActivationCode { get; set; }
        public string ReturnUrl { get; set; }

    }
}
