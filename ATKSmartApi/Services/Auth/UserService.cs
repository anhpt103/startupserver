using ATKSmartApi.Common.Constants;
using ATKSmartApi.Data;
using ATKSmartApi.Entities.Auth;
using ATKSmartApi.Helpers;
using ATKSmartApi.Models.Auth;
using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace ATKSmartApi.Services.Auth
{
    public interface IUserService
    {
        User Authenticate(string email, string password);
        string Register(RegisterModel model, out User user);
        IEnumerable<User> GetAll();
        UserProfileModel PostCurrentUser();
        string PostUserProfile(UserProfileModel model, out UserProfileModel outData);
    }

    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private readonly ATKSmartContext _dbContext;
        private readonly IMapper _mapper;

        public UserService(IOptions<AppSettings> appSettings, ATKSmartContext dbContext, IMapper mapper)
        {
            _appSettings = appSettings.Value;
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public User Authenticate(string email, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null) return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user;
        }

        public string Register(RegisterModel model, out User user)
        {
            user = null;
            var existsUser = _dbContext.Users.Any(x => x.Email == model.Email);
            if (existsUser) return MessageForUser.EMAIL_DUPLICATE;

            user = _mapper.Map<User>(model);
            if (user == null) return MessageForUser.OBJ_MAPPER_INVALID;

            _dbContext.Users.Add(user);

            int countSaved = _dbContext.SaveChanges();
            if (countSaved == 0) return MessageForUser.EXECUTE_CRUD_FAILD;

            return "";
        }

        public UserProfileModel PostCurrentUser()
        {
            var result = (from user in _dbContext.Users
                          join profile in _dbContext.UserProfiles
                          on user.UserId equals profile.UserId into pu
                          from subpro in pu.DefaultIfEmpty()
                          select new UserProfileModel
                          {
                              UserId = user.UserId,
                              UserProfileId = subpro.UserProfileId,
                              FirstName = subpro.FirstName ?? String.Empty,
                              LastName = subpro.LastName ?? String.Empty,
                              Address = subpro.Address ?? String.Empty,
                              Email = user.Email,
                              Password = user.Password,
                              PhoneNumber = user.PhoneNumber
                          });
            if (result.Count() > 0) return result.FirstOrDefault();
            return null;
        }

        public string PostUserProfile(UserProfileModel model, out UserProfileModel outData)
        {
            outData = null;
            var existsUser = _dbContext.Users.Any(x => x.UserId == model.UserId);
            if (!existsUser) return MessageForUser.USER_NOTFOUND;

            string msg = DoExcecuteUserProfile(model, out UserProfileModel outUserProfile);

            outData = outUserProfile;
            return msg;
        }

        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users;
        }

        private string DoExcecuteUserProfile(UserProfileModel model, out UserProfileModel outUserProfile)
        {
            string msg = "";
            outUserProfile = null;

            var userProfile = _mapper.Map<UserProfile>(model);
            if (userProfile == null) return MessageForUser.OBJ_MAPPER_INVALID;

            var existsUserProfile = _dbContext.UserProfiles.Any(x => x.UserId == model.UserId);
            if (existsUserProfile) _dbContext.UserProfiles.Update(userProfile);
            else _dbContext.UserProfiles.Add(userProfile);

            try
            {
                int count = _dbContext.SaveChanges();
                if (count <= 0) return MessageForUser.EXECUTE_CRUD_FAILD;

                outUserProfile =  _mapper.Map(userProfile, model);
            }
            catch (Exception ex) { msg = ex.Message; }

            return msg;
        }
    }
}
