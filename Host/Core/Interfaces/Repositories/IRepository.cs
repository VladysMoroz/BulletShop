using Core.Interfaces.DataManipulation;

namespace Core.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T model);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(int id, T model);
        Task DeleteAsync(int id);
        //public Task<List<T>> GetItemsByFilter(IFiltering filtering, ISorting sorting, IPagination pagination);
    }
}
