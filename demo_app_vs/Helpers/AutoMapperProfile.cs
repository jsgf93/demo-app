using AutoMapper;
using demo_app_vs.DTOs;
using demo_app_vs.Entities;

namespace demo_app_vs.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
