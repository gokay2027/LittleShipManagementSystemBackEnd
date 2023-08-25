using ListtleShipManagementSystemDomain.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace LittleShipManagementSystemData.Repositories.Abstract
{
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext _context;

        public EfCoreRepository(TContext context)
        {
            this._context = context;
        }

        public async Task<TEntity> AddandSave(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> AddRangeandSave(List<TEntity> entity)
        {
            _context.Set<TEntity>().AddRange(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> RemoveAndSave(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> GetById(int? id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> ModifyAndSave(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes)
        {
            var _dbSet = _context.Set<TEntity>();

            IIncludableQueryable<TEntity, object> query = null;

            if (includes.Length > 0)
            {
                query = _dbSet.Include(includes[0]);
            }
            for (int queryIndex = 1; queryIndex < includes.Length; ++queryIndex)
            {
                query = query.Include(includes[queryIndex]);
            }

            return query == null ? _dbSet : (IQueryable<TEntity>)query;
        }

        public async Task<IQueryable<TEntity>> GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Where(filter);
        }
    }
}