using AutoMapper;
using StartupApi.Entities.Auth;
using StartupApi.Models.Auth;

namespace StartupApi.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<RegisterModel, User>();
        }
    }
}
