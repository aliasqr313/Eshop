using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Data.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options)
        {

        }
    }
}
