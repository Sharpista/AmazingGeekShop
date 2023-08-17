using System.Linq.Expressions;
using AmazingGeekShop.Domain.Base;
using AmazingGeekShop.Domain.Interfaces.Common;
using AmazingGeekShop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace AmazingGeekShop.Infrastructure.Repositories.Base;

public class Repository<T> : IRepository<T> where T : EntityBase, new()
{
    private readonly ApplicationDbContext DbContext;
    private readonly DbSet<T> _DbSet;

    public Repository(ApplicationDbContext context)
    {
        DbContext = context;
        _DbSet = context.Set<T>();
    }

    public async Task<IEnumerable<T>> SearchBy(Expression<Func<T, bool>> predicate)
    {
        return await _DbSet.AsNoTracking().Where(predicate).ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _DbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _DbSet.FindAsync(id);
    }

    public async Task CreateAsync(T entity)
    {
        _DbSet.Add(entity);
        await SaveChanges();
    }

    public async Task UpdateAsync(T entity)
    {
        _DbSet.Update(entity);
        await SaveChanges();
    }

    public async Task RemoveAsync(T entity)
    {
        var result = await GetByIdAsync(entity.Id);
        _DbSet.Remove(result);
        await SaveChanges();
    }


    public async Task<int> SaveChanges()
    {
        return await DbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        DbContext?.Dispose();
    }
}