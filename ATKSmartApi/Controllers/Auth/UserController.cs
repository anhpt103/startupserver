using ATKSmartApi.Entities.Auth;
using ATKSmartApi.Models.Auth;
using ATKSmartApi.Services.Auth;
using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ATKSmartApi.Controllers.Auth
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            if (string.IsNullOrEmpty(model.Email)) return Ok(Result.Fail("Email không thể trống!"));
            if (string.IsNullOrEmpty(model.Password)) return Ok(Result.Fail("Mật khẩu không thể trống!"));

            var user = _userService.Authenticate(model.Email.ToLower(), model.Password.ToLower());

            if (user == null) return Ok(Result.Fail("Email hoặc mật khẩu không đúng!"));

            return Ok(Result.Ok(user));
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]RegisterModel model)
        {
            if (string.IsNullOrEmpty(model.Email)) return Ok(Result.Fail("Email không thể trống!"));
            if (string.IsNullOrEmpty(model.Password)) return Ok(Result.Fail("Mật khẩu không thể trống!"));
            if (string.IsNullOrEmpty(model.PhoneNumber)) return Ok(Result.Fail("Số điện thoại không thể trống!"));
            if (string.IsNullOrEmpty(model.Captcha)) return Ok(Result.Fail("Bạn chưa nhập mã Captcha!"));

            string msg = _userService.Register(model, out User user);
            if (msg.Length > 0) return BadRequest(new { message = msg });

            if (user == null) return Ok(Result.Fail("Đăng ký không thành công!"));

            return Ok(user);
        }

        [HttpPost("post_current_user")]
        public IActionResult PostCurrentUser()
        {
            var user = _userService.PostCurrentUser();
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
