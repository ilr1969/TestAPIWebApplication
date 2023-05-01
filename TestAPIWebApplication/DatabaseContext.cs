using Microsoft.EntityFrameworkCore;

namespace TestAPIWebApplication
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=TestApiDb;Trusted_Connection=True;trustServerCertificate=true;");
        }
    }
}
