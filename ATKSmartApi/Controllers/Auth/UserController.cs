using ATKSmartApi.Common.Constants;
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
            if (string.IsNullOrEmpty(model.Email)) return Ok(Result.Fail(MessageForUser.EMAIL_REQUIRE));
            if (string.IsNullOrEmpty(model.Password)) return Ok(Result.Fail(MessageForUser.PASSWORD_REQUIRE));

            var user = _userService.Authenticate(model.Email.ToLower(), model.Password.ToLower());

            if (user == null) return Ok(Result.Fail(MessageForUser.LOGIN_INVALID));

            return Ok(Result.Ok(user));
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]RegisterModel model)
        {
            if (string.IsNullOrEmpty(model.Email)) return Ok(Result.Fail(MessageForUser.EMAIL_REQUIRE));
            if (string.IsNullOrEmpty(model.Password)) return Ok(Result.Fail(MessageForUser.PASSWORD_REQUIRE));
            if (string.IsNullOrEmpty(model.PhoneNumber)) return Ok(Result.Fail(MessageForUser.PHONENUMBER_REQUIRE));
            if (string.IsNullOrEmpty(model.Captcha)) return Ok(Result.Fail("Bạn chưa nhập mã Captcha!"));

            string msg = _userService.Register(model, out User user);
            if (msg.Length > 0) return BadRequest(new { message = msg });

            if (user == null) return Ok(Result.Fail(MessageForUser.REGISTER_FAILD));

            return Ok(user);
        }

        [HttpPost("post_current_user")]
        public IActionResult PostCurrentUser()
        {
            return Ok(_userService.PostCurrentUser());
        }

        [HttpPost("post_user_profile")]
        public IActionResult PostUserProfile([FromBody]UserProfileModel model)
        {
            if (model.UserId <= 0) return Ok(Result.Fail(MessageForUser.EMAIL_REQUIRE));
            if (string.IsNullOrEmpty(model.Email)) return Ok(Result.Fail(MessageForUser.EMAIL_REQUIRE));
            if (string.IsNullOrEmpty(model.FirstName)) return Ok(Result.Fail(MessageForUser.FIRSTNAME_REQUIRE));
            if (string.IsNullOrEmpty(model.LastName)) return Ok(Result.Fail(MessageForUser.LASTNAME_REQUIRE));
            if (string.IsNullOrEmpty(model.Address)) return Ok(Result.Fail(MessageForUser.ADDRESS_REQUIRE));
            if (string.IsNullOrEmpty(model.PhoneNumber)) return Ok(Result.Fail(MessageForUser.PHONENUMBER_REQUIRE));

            string msg = _userService.PostUserProfile(model, out UserProfileModel outData);
            if (msg.Length > 0) return Ok(Result.Fail(msg));

            return Ok(Result.Ok(outData));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}
