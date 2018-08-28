using Microsoft.EntityFrameworkCore;
using mywebapp.api.Models;

namespace mywebapp.api.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;user id=sa;password=Pr0xxxy@!#;integrated security=false");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}