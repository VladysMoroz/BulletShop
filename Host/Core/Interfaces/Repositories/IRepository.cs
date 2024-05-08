﻿namespace Core.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T item);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(int id, T item);
        Task DeleteAsync(int id);
    }
}