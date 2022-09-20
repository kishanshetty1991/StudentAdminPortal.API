using AutoMapper;
using DomainModels = StudentAdminPortal.API.Domain_Models;
using DataModels = StudentAdminPortal.API.Data_Models;
namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, DomainModels.Student>()
                .ReverseMap();

            CreateMap<DataModels.Gender, DomainModels.Gender>()
                .ReverseMap();

            CreateMap<DataModels.Address, DomainModels.Address>()
                .ReverseMap();
        }
    }
}
