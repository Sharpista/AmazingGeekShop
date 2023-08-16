using AmazingGeekShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AmazingGeekShop.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {}

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Product>?Products { get; set; }
}