using ManageCompanies.Repository.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageCompanies.Service.Contract
{
    public interface IIdentificationTypeService
    {
        Task<List<IdentificationType>> GetAll();
    }
}
