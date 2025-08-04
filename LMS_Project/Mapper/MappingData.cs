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

        }
    }

}
