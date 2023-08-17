using Microsoft.EntityFrameworkCore;
using AmazingGeekShop.Domain.Entities;

namespace AmazingGeekShop.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        DbSet<Product> Products { get; set; }
    }
}