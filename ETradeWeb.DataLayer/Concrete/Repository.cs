using ETradeWeb.DataLayer.Abstract;
using ETradeWeb.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.DataLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        internal DatabaseContext _context;
        internal DbSet<T> _dbSet;

        public Repository(DatabaseContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public int Add(T entity)
        {
            _dbSet.Add(entity);
            return SaveChanges();
        }

        public async Task AddAsync(T entity)
        {
            await _context.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);

        }

        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public async  Task<T> FindAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async  Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).AsNoTracking().ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async  Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AsNoTracking().Where(expression).ToListAsync();
        }

        public IQueryable<T> GetAllInclude(string table)
        {
            return _dbSet.Include(table);
        }

        public async Task<T> GetIncludeAsync(Expression<Func<T, bool>> expression, string table)
        {
            return await _dbSet.Include(table).FirstOrDefaultAsync(expression);
        }

        public IQueryable<T> GetQueryable()
        {
            return _dbSet;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
