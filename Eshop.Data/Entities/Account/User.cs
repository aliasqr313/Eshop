namespace Eshop.Data.Entities.Account
{
    public class User
    {
       
        public string MobileNumber { get; set; }
        public string MobileActivationNumber { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PostCode { get; set; }

        public string? Addres { get; set; }
    }
}
