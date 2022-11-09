using MarketApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace MarketApp.Server.Data;

public class DataContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 1,
                Name = "Books",
                Url = "books"
            },
            new Category()
            {
                Id = 2,
                Name = "Games",
                Url = "games"
            },
            new Category()
            {
                Id = 3,
                Name = "Video Games",
                Url = "video-games"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Id = 1,
                Title = "A",
                Description = "PDDDD",
                Price = 9.99m,
                ImageUrl = "https://chaoskey.oschina.io/notes/images/0109.jpg",
                CategoryId = 1,
            },
            new Product()
            {
                Id = 2,
                Title = "B",
                Description = "PDDDD",
                Price = 19.99m,
                ImageUrl = "https://chaoskey.oschina.io/notes/images/0109.jpg",
                CategoryId = 1,
            },
            new Product()
            {
                Id = 3,
                Title = "C",
                Description = "PDDDD",
                Price = 29.99m,
                ImageUrl = "https://chaoskey.oschina.io/notes/images/0109.jpg",
                CategoryId = 1,
            }
        );
    }
}