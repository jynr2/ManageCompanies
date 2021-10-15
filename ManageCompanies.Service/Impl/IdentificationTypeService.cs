using ManageCompanies.Repository.Contract;
using ManageCompanies.Repository.Entities;
using ManageCompanies.Service.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageCompanies.Service.Impl
{
    public class IdentificationTypeService : IIdentificationTypeService
    {
        private readonly IIdentificationTypeRepository _identificationTypeRepository;

        public IdentificationTypeService(IIdentificationTypeRepository identificationTypeRepository)
        {
            _identificationTypeRepository = identificationTypeRepository;
        }
        public async Task<List<IdentificationType>> GetAll()
        {
            try
            {
                return await _identificationTypeRepository.GetAll();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
