using Microsoft.EntityFrameworkCore;

namespace VisionetTechTestFinal.Model
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> option) : base(option) 
        { 
        
        }

        public DbSet<CustomerDbContext> DbSet { get; set; }
    }
}
