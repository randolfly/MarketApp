using Bogus;
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
        // generate random category-5
        int categoryNum = 5;
        int categoryId = 1;
        var categoryGenerater = new Faker<Category>()
            //Ensure all properties have rules. By default, StrictMode is false
            //Set a global policy by using Faker.DefaultStrictMode
            .StrictMode(true)
            //OrderId is deterministic
            .RuleFor(o => o.Id, f => categoryId++)
            .RuleFor(o => o.Name, f => f.Random.Word())
            .RuleFor(o => o.Url, (f, o) => o.Name.ToLower());

        var randomCategories = categoryGenerater.Generate(categoryNum);
        modelBuilder.Entity<Category>().HasData(randomCategories);

        // generate random products-100
        int productNum = 100;
        int productId = 1;
        var productGenerater = new Faker<Product>()
            //Ensure all properties have rules. By default, StrictMode is false
            //Set a global policy by using Faker.DefaultStrictMode
            .StrictMode(false)
            //OrderId is deterministic
            .RuleFor(o => o.Id, f => productId++)
            .RuleFor(o => o.Title, f => f.Random.Word())
            .RuleFor(o => o.Description, f => f.Random.Words())
            .RuleFor(o => o.ImageUrl, f => f.Image.PicsumUrl())
            .RuleFor(o => o.CategoryId, f => f.Random.Number(min: 1, max: categoryId - 1))
            .RuleFor(o => o.Price, f => f.Random.Decimal());

        var randomProducts = productGenerater.Generate(productNum);
        // randomProducts.Sort((x, y) => x.Id - y.Id);
        modelBuilder.Entity<Product>().HasData(randomProducts);
    }
}