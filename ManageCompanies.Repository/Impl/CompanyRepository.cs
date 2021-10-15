using ManageCompanies.Repository.Context;
using ManageCompanies.Repository.Contract;
using ManageCompanies.Repository.Entities;

namespace ManageCompanies.Repository.Impl
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        private readonly ManageCompaniesContext _manageCompaniesContext;

        public CompanyRepository(ManageCompaniesContext manageCompaniesContext) :base(manageCompaniesContext)
        {
            _manageCompaniesContext = manageCompaniesContext;
        }
    }
}
