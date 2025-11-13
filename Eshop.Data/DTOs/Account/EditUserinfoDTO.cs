using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.DTOs.Account
{
    public class EditUserinfoDTO
    {
        [Display(Name = "")]
        [Required(ErrorMessage = "")]
        [MaxLength(200, ErrorMessage = "")]
        public string FullName { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "")]
        [MaxLength(200, ErrorMessage = "")]
        public string Email { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "")]
        [MaxLength(2000, ErrorMessage = "")]
        public string Address { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "")]
        [MaxLength(10, ErrorMessage = "")]
        public string PostCode { get; set; }
    }
}
