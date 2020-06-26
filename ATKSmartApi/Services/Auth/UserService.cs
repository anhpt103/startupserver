using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ATKSmartApi.Data;
using ATKSmartApi.Entities.Auth;
using ATKSmartApi.Helpers;
using ATKSmartApi.Models.Auth;
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
        User Authenticate(string username, string password);
        string Register(RegisterModel model, out User user);
        IEnumerable<User> GetAll();
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

        public User Authenticate(string username, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user == null) return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
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
            var existsUser = _dbContext.Users.Any(x => x.Username == model.Username);
            if (existsUser) return "Tên đăng nhập đã tồn tại";

            user = _mapper.Map<User>(model);
            if (user == null) return "Thông tin đăng ký tài khoản không đúng! Vui lòng kiểm tra lại";

            user.CreateDate = DateTime.Now;
            _dbContext.Users.Add(user);

            int countSaved = _dbContext.SaveChanges();
            if (countSaved == 0) return "Lỗi lưu cơ sở dữ liệu";

            return "";
        }

        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users;
        }
    }
}
