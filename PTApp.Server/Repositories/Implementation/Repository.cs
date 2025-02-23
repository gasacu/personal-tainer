using Microsoft.EntityFrameworkCore;
using PTApp.Server.Data;
using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Repositories.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;
        
        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entityInDb = await _dbSet.FindAsync(id);

            if(entityInDb == null)
            {
                throw new KeyNotFoundException($"Employee with id {id} was not found.");
            }

            _dbSet.Remove(entityInDb);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
