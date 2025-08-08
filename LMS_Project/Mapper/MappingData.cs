using AutoMapper;
using LMS_Project.DTO;
using LMS_Project.Models;

namespace LMS_Project.Mapper
{
    public class MappingData : Profile
    {
        public MappingData()
        {
            CreateMap<Users, UserDto>().ReverseMap();
            CreateMap<UserRoles, UserRoleDto>().ReverseMap();
            CreateMap<Roles,RolesDto>().ReverseMap();
            CreateMap<Countries, CountryDto>().ReverseMap();
            CreateMap<States, StatesDto>().ReverseMap();
            CreateMap<States, GetStatesDTO>().ForMember(x => x.CountryName, a => a.MapFrom(b => b.Countries != null ? b.Countries.CountryName : "No"));
            CreateMap<Cities, CitiesDto>().ReverseMap();
            CreateMap<Cities, GetCitiesDTO>().ForMember(x => x.StateName, a => a.MapFrom(b => b.States != null ? b.States.StateName : "No"));
            CreateMap<Pincodes, PinCodesDto>().ReverseMap();
            CreateMap<Pincodes, GetPincodesDTO>().ForMember(x => x.CityName, a => a.MapFrom(b => b.Cities != null ? b.Cities.CityName : "No"))
   .ForMember(x => x.StateName, a => a.MapFrom(b => b.States != null ? b.States.StateName : "No"))
   .ForMember(x => x.CountryName, a => a.MapFrom(b => b.Countries != null ? b.Countries.CountryName : "No"));
            CreateMap<RejectionReason, RejectionReasonDto>().ReverseMap();
            CreateMap<EmploymentType, EmploymentTypeDto>().ReverseMap();
            CreateMap<Bank, BankDto>().ReverseMap();
            CreateMap<OccupationType, OccupationTypeDto>().ReverseMap();
            CreateMap<DocumentType, DocumentTypeDto>().ReverseMap();
            CreateMap<Department,DepartmentDto>().ReverseMap();
            CreateMap<Branch,BranchDto>().ReverseMap();
            CreateMap<Branch, GetBranchDTO>().ForMember(x => x.CityName, a => a.MapFrom(b => b.Cities != null ? b.Cities.CityName : "No"))
                .ForMember(x => x.StateName, b => b.MapFrom(b => b.States != null ? b.States.StateName : "No"))
                .ForMember(x => x.CountryName, b => b.MapFrom(b => b.Countries != null ? b.Countries.CountryName : "No"));
            CreateMap<Department, EditDepartmentDto>().ReverseMap();
            CreateMap<DocumentType, EditDocumentTypeDto>().ReverseMap();
            CreateMap<EmploymentType, EditEmploymentTypeDto>().ReverseMap();
            CreateMap<OccupationType, EditOccupationTypeDto>().ReverseMap();
            CreateMap<Pincodes,EditPincodesDto>().ReverseMap();
            CreateMap<Branch, EditBranchDto>().ReverseMap();
            CreateMap<Users, EditUserDto>().ReverseMap();
            CreateMap<RejectionReason, EditRejectionReasonDto>().ReverseMap();
            CreateMap<Bank, EditBankDto>().ReverseMap();
        }
    }


  
////CreateMap<Branch, GetBranchDTO>().ForMember(x => x.StateName, a => a.MapFrom(b => b.states != null ? b.states.StateName : "No"));
//CreateMap<Branch, GetBranchDTO>().ForMember(x => x.CityName, a => a.MapFrom(b => b.cities != null ? b.cities.CityName : "No"))
//    .ForMember(x => x.StateName, a => a.MapFrom(b => b.states != null ? b.states.StateName : "No"))
//    .ForMember(x => x.CountryName, a => a.MapFrom(b => b.countries != null ? b.countries.CountryName : "No"));

}
