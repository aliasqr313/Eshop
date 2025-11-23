using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.DTOs.Account
{
    public class LoginDTO
    {
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(11, ErrorMessage = "{نمیتواند بیشتر از {1}  کاراکتر باشد{0")]
        public string MobileNumber { get; set; }
        public string? ReturnUrl { get; set; }   //ریدایرکت کردن به صفحه ای که کاربر قرار داشت
    }
}
