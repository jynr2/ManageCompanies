using ManageCompanies.Repository.Context;
using ManageCompanies.Repository.Contract;
using ManageCompanies.Repository.Entities;

namespace ManageCompanies.Repository.Impl
{
    public class IdentificationTypeRepository : RepositoryBase<IdentificationType>, IIdentificationTypeRepository
    {
        private readonly ManageCompaniesContext _manageCompaniesContext;
        public IdentificationTypeRepository(ManageCompaniesContext manageCompaniesContext) : base(manageCompaniesContext)
        {
            _manageCompaniesContext = manageCompaniesContext;
        }
    }
}
