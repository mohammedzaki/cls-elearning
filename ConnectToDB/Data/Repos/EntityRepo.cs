using ConnectToDB.Models;

namespace ConnectToDB.Data.Repos
{
    public class EntityRepo<TEntity> : IRepo<TEntity>
    {
        ApplicationDbContext _dbContext;

        public EntityRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public async Task<TEntity> Save(TEntity entity) 
        {
            _dbContext.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

    }
}
