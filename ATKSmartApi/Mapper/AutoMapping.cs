using ATKSmartApi.Entities.Auth;
using ATKSmartApi.Models.Auth;
using AutoMapper;

namespace ATKSmartApi.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<RegisterModel, User>();
            CreateMap<UserProfileModel, UserProfile>().ReverseMap();
        }
    }
}
