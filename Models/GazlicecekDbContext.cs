using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Models
{
    public class GazlicecekDbContext:DbContext
    {

        public GazlicecekDbContext(DbContextOptions<GazlicecekDbContext> options) : base(options)
        {
        
        }
            
        public DbSet<Gazlicecek> Gazliceceks { get; set; }
     
    }
}
