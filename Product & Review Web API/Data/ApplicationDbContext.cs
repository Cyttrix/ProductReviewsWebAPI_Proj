using Microsoft.EntityFrameworkCore;

namespace Product___Review_Web_API.obj
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
        
        }
    }
}
