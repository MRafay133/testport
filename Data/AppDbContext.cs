using Microsoft.EntityFrameworkCore;
using testport.Models;

namespace testport.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }

        public DbSet<Login> Login { get; set; }
    }
}
