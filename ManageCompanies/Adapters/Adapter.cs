using AutoMapper;
using ManageCompanies.Repository.Entities;
using ManageCompanies.Service.Models;

namespace ManageCompanies.Web.Adapters
{
    public class Adapter : Profile
    {
        public Adapter()
        {
            CreateMap<Company, CompanyModel>().ReverseMap();
            CreateMap<CompanyModel, Company>().ReverseMap();

            CreateMap<IdentificationType, IdentificationTypeModel>().ReverseMap();
            CreateMap<IdentificationTypeModel, IdentificationType>().ReverseMap();
        }
    }
}
