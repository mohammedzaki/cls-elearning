using ConnectToDB.Models;

namespace ConnectToDB.Data.Repos
{
    public interface IRepo<TEntity>
    {
        public Task<TEntity> Save(TEntity entity);
    }
}
