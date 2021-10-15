using ManageCompanies.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageCompanies.Repository.Contract
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<Tuple<StatusCodeEnum, T>> Add(T entity);
        Task<List<T>> GetAll();
    }
}
