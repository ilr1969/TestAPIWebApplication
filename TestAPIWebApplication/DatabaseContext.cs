using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;

namespace TestAPIWebApplication
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Person> Persons { get; set; }

        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            await GetSourceData.SetData();
            var persons = GetSourceData.GetData();
            modelBuilder.Entity<Person>().HasData(persons);
        }
    }
}
