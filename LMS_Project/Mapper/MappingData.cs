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
            CreateMap<Cities, CitiesDto>().ReverseMap();
            CreateMap<Pincodes, PinCodesDto>().ReverseMap();
            CreateMap<RejectionReason, RejectionReasonDto>().ReverseMap();
            CreateMap<EmploymentType, EmploymentTypeDto>().ReverseMap();
            CreateMap<Bank, BankDto>().ReverseMap();
            CreateMap<OccupationType, OccupationTypeDto>();
            CreateMap<DocumentType, DocumentTypeDto>().ReverseMap();
            CreateMap<Department,DepartmentDto>().ReverseMap();
            CreateMap<Branch,BranchDto>().ReverseMap();
        }
    }

}
