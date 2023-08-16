using AmazingGeekShop.Domain.Entities;
using AmazingGeekShop.Domain.Interfaces.Common;

namespace AmazingGeekShop.Infrastructure.Repositories;

public class ProductRepository : IRepository<Product>
{
    public Task<IEnumerable<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> CreateAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task<Product> UpdateAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task<Product> RemoveAsync(Product entity)
    {
        throw new NotImplementedException();
    }
}