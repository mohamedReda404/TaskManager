using Microsoft.EntityFrameworkCore;
using Task_Manager.Models;

namespace Task_Manager.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options):DbContext(options)
    {
        public DbSet<Users> users {  get; set; }
        public DbSet<Tasks> tasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
