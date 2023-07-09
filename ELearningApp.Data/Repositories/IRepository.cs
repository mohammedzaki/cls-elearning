using ELearningApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ELearningApp.Data.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> FindById(int id);

        Task SaveAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);
    }
}
