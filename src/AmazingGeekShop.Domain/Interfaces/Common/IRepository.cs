using System.Linq.Expressions;

namespace AmazingGeekShop.Domain.Interfaces.Common;

public interface IRepository<T> : IDisposable where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(Guid id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task RemoveAsync(T entity);
    Task<int> SaveChanges();
    Task<IEnumerable<T>> SearchBy(Expression<Func<T, bool>> predicate);
}