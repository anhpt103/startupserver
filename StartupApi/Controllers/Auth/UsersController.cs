using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartupApi.Entities.Auth;
using StartupApi.Models.Auth;
using StartupApi.Services.Auth;

namespace StartupApi.Controllers.Auth
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            if (string.IsNullOrEmpty(model.Username)) return BadRequest(new { message = "Tên đăng nhập không thể trống!" });
            if (string.IsNullOrEmpty(model.Password)) return BadRequest(new { message = "Mật khẩu không thể trống!" });

            var user = _userService.Authenticate(model.Username.ToLower(), model.Password.ToLower());

            if (user == null) return BadRequest(new { message = "Tên đăng nhập hoặc mật khẩu không đúng!" });

            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]RegisterModel model)
        {
            if (string.IsNullOrEmpty(model.Username)) return BadRequest(new { message = "Tên đăng nhập không thể trống!" });
            if (string.IsNullOrEmpty(model.Password)) return BadRequest(new { message = "Mật khẩu không thể trống!" });
            if (string.IsNullOrEmpty(model.FirstName)) return BadRequest(new { message = "Họ tên không thể trống!" });
            if (string.IsNullOrEmpty(model.LastName)) return BadRequest(new { message = "Tên không thể trống!" });

            string msg = _userService.Register(model, out User user);
            if (msg.Length > 0) return BadRequest(new { message = msg });

            if (user == null) return BadRequest(new { message = "Đăng ký không thành công!" });

            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}
