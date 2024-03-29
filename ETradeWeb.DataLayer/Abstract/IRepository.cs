﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.DataLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAllInclude(string table);
        IQueryable<T> GetQueryable();
        T Get(Expression<Func<T, bool>> expression);
        T Find(int id);
        int Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int SaveChanges();

       
        Task<T> FindAsync(int id);
        Task<T> GetIncludeAsync(Expression<Func<T, bool>> expression, string table);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task<int> SaveChangesAsync();
    }
}
