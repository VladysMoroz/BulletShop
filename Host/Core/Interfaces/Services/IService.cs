namespace Core.Interfaces.Services
{
    public interface IService<T> where T : class
    {
        Task<T> CreateAsync(T model);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(int id, T model);
        Task DeleteAsync(int id);

    }
}
