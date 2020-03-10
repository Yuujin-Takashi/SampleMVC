using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TestProject.Models
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
            
        }
        public DbSet<TestPurchase> TestPurchase {get; set;}
        public DbSet<User> User {get; set;}
    }
}
