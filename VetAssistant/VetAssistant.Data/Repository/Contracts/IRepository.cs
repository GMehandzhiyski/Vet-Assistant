namespace VetAssistant.Data.Repository.Interfaces
{
    public interface IRepository<TType, TId>
    {
        void Add(TType item);
        Task AddAsync(TType item);

        IEnumerable<TType> GetAll();
        Task<IEnumerable<TType>> GetAllAsync();

        TType GetById(TId id);
        Task<TType> GetByIdAsync(TId id);

        bool Update(TType item);
        Task<bool> UpdateAsync(TType item);

        bool Delete(TId id);
        Task<bool> DeleteAsync(TId id);

        bool SoftDelete(TId id);
        Task<bool> SoftDeleteAsync(TId id);

    }
}
