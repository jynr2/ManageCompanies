using ManageCompanies.Repository.Context;
using ManageCompanies.Repository.Contract;
using ManageCompanies.Repository.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageCompanies.Repository.Impl
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ManageCompaniesContext _manageCompaniesContext;

        public RepositoryBase(ManageCompaniesContext manageCompaniesContext)
        {
            _manageCompaniesContext = manageCompaniesContext;
        }
        public async Task<Tuple<StatusCodeEnum, T>> Add(T entity)
        {
            try
            {
                _manageCompaniesContext.Set<T>().Add(entity);

                if (await _manageCompaniesContext.SaveChangesAsync() > 0)
                    return Tuple.Create(StatusCodeEnum.success, entity);
                else
                    return Tuple.Create(StatusCodeEnum.error, entity);
            }
            catch (Exception)
            {
                return Tuple.Create(StatusCodeEnum.error, entity);
            }
        }

        public async Task<List<T>> GetAll()
        {
            try
            {
                return await _manageCompaniesContext.Set<T>().ToListAsync();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
