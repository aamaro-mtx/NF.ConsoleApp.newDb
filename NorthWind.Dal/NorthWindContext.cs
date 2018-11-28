using Microsoft.EntityFrameworkCore;
using NorthWind.Entities;

namespace NorthWind.Dal
{
    public class NorthWindContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=.\SQL2017;Database=NorthwindPoc;Trusted_Connection=true;");
        }
    }
}