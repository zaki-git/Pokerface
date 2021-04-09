﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokerface.Contracts.ServiceContracts
{
    public interface IGenericRepository<T>  where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
    }
}
