using Microsoft.EntityFrameworkCore;
using VetAssistant.Data.Repository.Interfaces;

namespace VetAssistant.Data.Repository
{
    public class Repository<TType, TId> : IRepository<TType, TId>
        where TType : class
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
            throw new NotImplementedException();
        }

        public Task AddAsync(TType item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TId id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TType> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public TType GetById(TId id)
        {
            TType entity = dbSet
                .Find(id);

            return entity;
        }

        public Task<TType> GetByIdAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public bool SoftDelete(TId id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDeleteAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public bool Update(TType item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TType item)
        {
            throw new NotImplementedException();
        }
    }
}
