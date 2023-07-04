using ELearningApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ELearningApp.Data.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> FindById(int id);

        Task SaveAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);
    }
}
