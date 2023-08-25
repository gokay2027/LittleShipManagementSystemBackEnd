using ListtleShipManagementSystemDomain.Abstract;
using System.Linq.Expressions;

namespace LittleShipManagementSystemData.Repositories.Abstract
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int? id);

        Task<T> AddandSave(T entity);

        Task<T> ModifyAndSave(T entity);

        Task<T> RemoveAndSave(int id);

        Task<List<T>> AddRangeandSave(List<T> entity);

        IQueryable<T> Include(params Expression<Func<T, object>>[] includes);

        Task<IQueryable<T>> GetByFilter(Expression<Func<T, bool>> filter);
    }
}