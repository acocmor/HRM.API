using AutoMapper;
using HRM.API.Models.Auth;
using HRM.API.Models.User;
using HRM.Entity.Entities;

namespace HRM.API.Core.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //User Map
            CreateMap<User, GetUserDTO>().ReverseMap();
            CreateMap<User, LoginDTO>().ReverseMap();
            CreateMap<GetUserDTO, LoginDTO>().ReverseMap();
            CreateMap<CreateUserDTO, User>();
            CreateMap<ChangePasswordDTO, User>();
        }
    }
}
