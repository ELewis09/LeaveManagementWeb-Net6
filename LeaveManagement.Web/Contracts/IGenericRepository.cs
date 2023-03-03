﻿namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int? id);
        Task UpdateAsync(T entity); 
        Task DeleteAsync (int id);
        Task<T> AddAsync(T entity);
        Task<bool> Exist (int id);
    }
}
