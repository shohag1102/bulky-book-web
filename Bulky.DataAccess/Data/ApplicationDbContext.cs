using Bulky.Models;
using Bulky.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                        new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                        new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                        new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );
            modelBuilder.Entity<Product>().HasData(
                     new Product
                     {
                         Id = 1,
                         Title = "Days Gone by (Hardcover)",
                         Description = "Non voluptas cupiditate ut ut voluptas, dolor sit amet consectetur",
                         ISBN = "978-1234567897",
                         Author = "James Watter",
                         ListPrice = 99,
                         Price = 90,
                         Price50 = 85,
                         Price100 = 80
                     },
                     new Product
                     {
                         Id = 2,
                         Title = "The Winds Call",
                         Description = "Dolor sit amet consectetur adipiscing elit sed do eiusmod",
                         ISBN = "978-2234567897",
                         Author = "Helena Yellow",
                         ListPrice = 40,
                         Price = 30,
                         Price50 = 25,
                         Price100 = 20
                     },
                     new Product
                     {
                         Id = 3,
                         Title = "The Origin of Species",
                         Description = "Tempor incididunt ut labore et dolore magna aliqua enim ad minim veniam",
                         ISBN = "978-3234567897",
                         Author = "Charles Darwin",
                         ListPrice = 50,
                         Price = 40,
                         Price50 = 35,
                         Price100 = 30
                     },
                     new Product
                     {
                         Id = 4,
                         Title = "The Silent Ocean",
                         Description = "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris",
                         ISBN = "978-4234567897",
                         Author = "Marcus Reyed",
                         ListPrice = 60,
                         Price = 50,
                         Price50 = 45,
                         Price100 = 40
                     },
                     new Product
                     {
                         Id = 5,
                         Title = "Chronicles of the Forgotten",
                         Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem",
                         ISBN = "978-5234567897",
                         Author = "Elena Wraith",
                         ListPrice = 120,
                         Price = 110,
                         Price50 = 100,
                         Price100 = 90
                     },
                     new Product
                     {
                         Id = 6,
                         Title = "A Brief History of Time",
                         Description = "Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse",
                         ISBN = "978-6234567897",
                         Author = "Stephen Hawking",
                         ListPrice = 75,
                         Price = 65,
                         Price50 = 60,
                         Price100 = 55
                     }
                );

        }
    }
}