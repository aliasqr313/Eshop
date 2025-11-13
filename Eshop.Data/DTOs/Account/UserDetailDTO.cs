using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.DTOs.Account
{
    public class UserDetailDTO
    {
        [Key]
        public long id { get; set; }
        public DateTime CreatData { get; set; }
        public DateTime LastUpdateData { get; set; }
        public bool IsDeleted { get; set; }
        public string MobileNumber { get; set; }
        public string MobileActivationNumber { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PostCode { get; set; }

        public string? Addres { get; set; }
    }
}
