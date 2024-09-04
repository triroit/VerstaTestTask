using VerstaTestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace VerstaTestTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Order> Orders { get; set; }
    }
}
