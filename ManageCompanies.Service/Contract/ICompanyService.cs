using ManageCompanies.Repository.Entities;
using ManageCompanies.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageCompanies.Service.Contract
{
    public interface ICompanyService
    {
        Task<Tuple<StatusCodeEnum, Company>> AddCompany(Company company);
    }
}
