using TelephoneDirectory.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace TelephoneDirectory.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> People { get; set; } = null!;
        public DbSet<City> City { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) => Database.EnsureCreated();
    }
}