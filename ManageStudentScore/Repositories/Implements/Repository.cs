using ManageStudentScore.Models;
using ManageStudentScore.Repositories.Inferfaces;
using Microsoft.EntityFrameworkCore;

namespace ManageStudentScore.Repositories.Implements
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly MyDBContext _context;
        protected DbSet<T> dbSet;

        public Repository(MyDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            dbSet = _context.Set<T>();
        }
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            T? result = await dbSet.FindAsync(id);
            return result;
        }

        public async Task InsertAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    
    }
}
