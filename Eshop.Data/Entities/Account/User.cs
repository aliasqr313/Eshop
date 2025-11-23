using Eshop.Data.Entities.Common;

namespace Eshop.Data.Entities.Account
{
    public class User : BaseEntity
    {
       
        public string MobileNumber { get; set; }
        public string MobileActivationNumber { get; set; }    //کدی که برای احراز هویت برای کاربر فرستاده میشه
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PostCode { get; set; }               //کد پستی کاربر

        public string? Address { get; set; }
    }
}
