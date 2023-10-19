using FirstMVCWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCWebApp.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)       {
            
        }

        public DbSet<Category> Categories { get; set; } 

    }
}
