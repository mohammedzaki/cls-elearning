using ELearningApp.Data.Entities;
using Microsoft.CodeAnalysis.Classification;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace ELearningApp.Data.Repositories
{
    public class EntityRepository<TEntity> : IRepository<TEntity> 
        where TEntity : class, IEntity, new()
    {
        protected readonly ApplicationDbContext _context;

        public EntityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual async Task<TEntity> FindById(int id)
        {
            var entity = await _context.Set<TEntity>()
                .Where(e => e.Id == id)
                .FirstOrDefaultAsync();
            return entity;
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            var entities = await _context.Set<TEntity>().ToListAsync();
            return entities;
        }

        public virtual async Task SaveAsync(TEntity entity) 
        {
            //entity.Id = NewId();
            entity.CreatedAt = DateTime.UtcNow;
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
