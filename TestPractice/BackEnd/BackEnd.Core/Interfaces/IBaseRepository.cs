namespace BackEnd.Core.Interfaces
{
    using BackEnd.Core.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();

        Task<TEntity> GetByIdAsync(int id);

        Task<TEntity> CreateAsync(TEntity entity);

        Task<bool> UpdateAsync(TEntity entity);

        Task<bool> DeleteAsync(int id);

    }
}
