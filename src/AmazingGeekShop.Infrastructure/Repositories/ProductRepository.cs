using AmazingGeekShop.Domain.Entities;
using AmazingGeekShop.Domain.Interfaces.Common;
using AmazingGeekShop.Infrastructure.Context;
using AmazingGeekShop.Infrastructure.Repositories.Base;

namespace AmazingGeekShop.Infrastructure.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}