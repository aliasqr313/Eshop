using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.DTOs.Account
{
    public class RegisterUserDTO
    {
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(11, ErrorMessage = "شماره موبایل نمیتواند بیشتر از 11 رقم باشد")]
        public string MobileNumber { get; set; }
    }
}
