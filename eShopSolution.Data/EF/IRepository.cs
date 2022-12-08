using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Data.EF
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>>? filter = null);
        Task<IEnumerable<T>> GetListAsync(int skip, int take, Expression<Func<T, bool>>? filter = null);
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        List<EntityAttribute> GetEntityAttributes();
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EShopDbContext _context;
        public Repository(EShopDbContext context) => _context = context;

        public void Add(T entity) => _context.Set<T>().Add(entity);
        public void AddRange(IEnumerable<T> entities) => _context.Set<T>().AddRange(entities);
        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter) => await _context.Set<T>().Where(filter).FirstOrDefaultAsync();
        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
        public async Task<T> GetByIdAsync(string id) => await _context.Set<T>().FindAsync(id);
        public void Remove(T entity) => _context.Set<T>().Remove(entity);
        public void RemoveRange(IEnumerable<T> entities) => _context.Set<T>().RemoveRange(entities);
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public void UpdateRange(IEnumerable<T> entities) => _context.Set<T>().UpdateRange(entities);

        public async Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>>? filter = null)
        {
            if (filter == null) return await _context.Set<T>().ToListAsync();
            return await _context.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetListAsync(int skip, int take, Expression<Func<T, bool>>? filter = null)
        {
            if (filter != null)
                return await _context.Set<T>().Where(filter).Skip(skip).Take(take).ToListAsync();
            return await _context.Set<T>().Skip(skip).Take(take).ToListAsync();
        }

        public virtual List<EntityAttribute> GetEntityAttributes()
        {
             return typeof(T).GetProperties()
               .Select(property => new EntityAttribute
               {
                   ColumnAttribute = property.GetCustomAttribute<ColumnAttribute>().Name,
                   Field = property.Name,
                   DisplayAttribute = property.GetCustomAttribute<DisplayAttribute>() != null ? property.GetCustomAttribute<DisplayAttribute>().Name : String.Empty,
               }).ToList();
        }
    }
    public class EntityAttribute
    {
        public string ColumnAttribute { get; set; }
        public string Field { get; set; }
        public string DisplayAttribute { get; set; }
    }
}


