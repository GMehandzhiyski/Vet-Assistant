using Microsoft.EntityFrameworkCore;
using VetAssistant.Data.Models;
using VetAssistant.Data.Repository.Interfaces;

namespace VetAssistant.Data.Repository
{
    public class Repository<TType, TId> : IRepository<TType, TId>
        where TType : class, IDeletableEntity
    {
        private readonly VetAssistantDbContext context;
        private readonly DbSet<TType> dbSet;

        public Repository(VetAssistantDbContext _context)
        {
            context = _context;
            dbSet = context.Set<TType>();
        }

        public void Add(TType item)
        {
            dbSet.Add(item);
            context.SaveChanges();
        }

        public async Task AddAsync(TType item)
        {
            await dbSet.AddAsync(item);
            await context.SaveChangesAsync();
        }

        public bool Delete(TId id)
        {
            TType entity = GetById(id);
            if (entity == null)
            {
                return false;
            }

            dbSet.Remove(entity);
            context.SaveChanges();

            return true;
        }

        public async Task<bool> DeleteAsync(TId id)
        {
            TType entity = await GetByIdAsync(id);
            if (entity == null)
            {
                return false;
            }

            dbSet.Remove(entity);
            await context.SaveChangesAsync();

            return true;
        }

        public IEnumerable<TType> GetAll()
        {
            return dbSet.ToArray();
        }

        public async Task<IEnumerable<TType>> GetAllAsync()
        {
            return await dbSet.ToArrayAsync();
        }

        public IEnumerable<TType> GetAllAttached()
        {
            return dbSet.AsQueryable();
        }

        public TType GetById(TId id)
        {
            TType entity = dbSet
                .Find(id);

            return entity;
        }

        public async Task<TType> GetByIdAsync(TId id)
        {
            TType entity = await dbSet
               .FindAsync(id);

            return entity;
        }

        public bool SoftDelete(TId id)
        {
            var entity = GetById(id);
            if (entity == null)
            {
                return false;
            }

            entity.IsDeleted = true;
            context.SaveChanges();
            return true;
        }

        public async Task<bool> SoftDeleteAsync(TId id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
            {
                return false;
            }

            entity.IsDeleted = true;
            await context.SaveChangesAsync();
            return true;
        }

        public bool Update(TType item)
        {
            try
            {
                dbSet.Attach(item);
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<bool> UpdateAsync(TType item)
        {
            try
            {
                dbSet.Attach(item);
                context.Entry(item).State = EntityState.Modified;
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
