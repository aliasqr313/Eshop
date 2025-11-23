using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.DTOs.Account
{
    public class EditUserinfoDTO
    {
        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {1}  کاراکتر باشد{0")]
        public string FullName { get; set; }

        [Display(Name = "ایمیل")]
        
        [MaxLength(200, ErrorMessage = "{نمیتواند بیشتر از {1}  کاراکتر باشد{0")]
        public string Email { get; set; }


        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(300, ErrorMessage = "{نمیتواند بیشتر از {1}  کاراکتر باشد{0")]
        public string Address { get; set; }


        [Display(Name = "کدپستی")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(10, ErrorMessage = "{نمیتواند بیشتر از {1}  کاراکتر باشد{0")]
        public string PostCode { get; set; }
    }
}
