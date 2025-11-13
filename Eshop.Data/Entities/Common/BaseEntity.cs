using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Eshop.Data.Entities.Common
{
    public class BaseEntity
    {
        [Key]
        public long id { get; set; }
        public DateTime CreatData { get; set; }
        public DateTime LastUpdateData { get; set; }
        public bool IsDeleted { get; set; }
    }
}
