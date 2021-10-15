using AutoMapper;
using ManageCompanies.Repository.Contract;
using ManageCompanies.Repository.Entities;
using ManageCompanies.Repository.Enums;
using ManageCompanies.Service.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageCompanies.Service.Impl
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public async Task<Tuple<StatusCodeEnum, Company>> AddCompany(Company company)
        {
            try
            {
                var response = await _companyRepository.Add(company);
                return Tuple.Create(response.Item1, response.Item2);
            }
            catch (Exception)
            {
                return Tuple.Create(StatusCodeEnum.error, company);
            }
        }
    }
}
