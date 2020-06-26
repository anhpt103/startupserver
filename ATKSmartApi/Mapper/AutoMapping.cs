using AutoMapper;
using ATKSmartApi.Entities.Auth;
using ATKSmartApi.Models.Auth;

namespace ATKSmartApi.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<RegisterModel, User>();
        }
    }
}
