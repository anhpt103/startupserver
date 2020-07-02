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
    public class StoreController : ControllerBase
    {
        private IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpPost("post_store")]
        public IActionResult PostAllStore()
        {
            return Ok(Result.Ok(_storeService.PostStore()));
        }

        [HttpPost("post_cru_store")]
        public IActionResult PostCRUStore([FromBody]StoreModel model)
        {
            string msg = _storeService.PostCRUStore(model, out StoreModel outStore);
            if (msg.Length > 0) return Ok(Result.Fail(msg));

            return Ok(Result.Ok(outStore));
        }
    }
}
