using AgroMarket.Shared.Exception;
using Microsoft.EntityFrameworkCore;

namespace AgroMarket.Data.Repository;

public class BaseRepository<T> where T : class
{
    private AmContext _context;
    private DbSet<T> _set;
    public BaseRepository(AmContext context)
    {
        _context = context;
        _set = context.Set<T>();
    }

    public async Task InsertAsync(T entity)
    {
        _ = _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }
    public IQueryable<T> GetQueryable()
    {
        return _set;
    }
    public async Task<T?> GetByIdAsync(int id)
    {
        return await _set.FindAsync(id).ConfigureAwait(false);
    }
}