using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.DTOs.Account
{
    public class MobileActivationDTO
    {
        [Display(Name = "کد فعالسازی")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(11, ErrorMessage = "کد فعالسازی نمیتواند بیشتر از 5 رقم باشد")]
        public string ActivationCode { get; set; }
        public string ReturnUrl { get; set; }

    }
}
