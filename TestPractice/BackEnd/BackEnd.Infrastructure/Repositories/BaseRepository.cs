using BackEnd.Core.Entities;
using BackEnd.Core.Interfaces;
using BackEnd.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DataContext _context;
        protected readonly DbSet<TEntity> _entities;
        public BaseRepository(DataContext context)
        {

            _context = context ?? throw new ArgumentNullException();

            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {

            return _entities.AsEnumerable();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            return await ProcessCreateAsync(entity);
        }

        private async Task<TEntity> ProcessCreateAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
             await _context.SaveChangesAsync();
            return entity;

        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            return await ProcessUpdateAsync(entity);
        }

        private async Task<bool> ProcessUpdateAsync(TEntity entity)
        {
            _entities.Update(entity);
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            TEntity entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _entities.Remove(entity);

                return await _context.SaveChangesAsync() > 0;

            }
            return false;
        }

    }
}
