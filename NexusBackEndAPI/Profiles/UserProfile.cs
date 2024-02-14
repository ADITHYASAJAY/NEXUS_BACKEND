using AutoMapper;
using NexusUserBackend.DTO;
using NexusUserBackend.Entities;
namespace NexusUserBackend.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();
        }
    }
}
