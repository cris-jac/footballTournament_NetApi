﻿using Microsoft.EntityFrameworkCore;
using Model.Interfaces;
using Repository.Data;

namespace Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;
        internal DbSet<T> _dbSet { get; set; }
        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Edit(T entity)
        {
            _dbSet.Update(entity);
        }

        // Marked as virtual -> To enable modifications
        public virtual async Task<List<T>> GetAll()
        {
            //return await _dbSet.ToListAsync();
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T?> GetId(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        //
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

    }
}