using ATKSmartApi.Entities.Auth;
using ATKSmartApi.Models.Auth;
using AutoMapper;

namespace ATKSmartApi.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserStoreModel>();
            CreateMap<UserStore, UserStoreModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<StoreModel, Store>().ReverseMap();
            CreateMap<UserProfileModel, UserProfile>().ReverseMap();
        }
    }
}
