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

    public void InsertAsync(T entity)
    {
        _ = _context.AddAsync(entity);
        _context.SaveChangesAsync();
    }
}