using Exam.ApplicationCore.Interfaces;
using Exam.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Exam.Infrastracture
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbset;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            _dbset.Add(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            _dbset.Remove(entity);
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return _dbset.AsEnumerable();
        }

        public async Task<T> GetByIdAsync(params object[] keyValues)
        {
            return _dbset.Find(keyValues);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbset.Update(entity);
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> where)
        {
            _dbset.RemoveRange(_dbset.Where(where));
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> where)
        {
            return _dbset.Where(where).FirstOrDefault();
        }

        public async Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where)
        {
            return _dbset.Where(where).AsEnumerable();
        }
    }
}
