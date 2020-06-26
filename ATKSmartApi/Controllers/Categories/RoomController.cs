using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ATKSmartApi.Entities.Categories;
using ATKSmartApi.Services.Categories;
using System.Threading.Tasks;

namespace ATKSmartApi.Controllers.Categories
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {
        private IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        [Route("GetAllRoom")]
        public async Task<IActionResult> GetAllRoom()
        {
            var rooms = await _roomService.GetAll();
            return Ok(rooms);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var room = await _roomService.GetById(id);
            if(room == null) return NotFound("Không tìm thấy dữ liệu");

            return Ok(room);
        }

        [HttpPost]
        [Route("AddRoom")]
        public async Task<IActionResult> AddRoom([FromBody]Room model)
        {
            if (!ModelState.IsValid) return BadRequest("Dữ liệu đầu vào không hợp lệ");

            string msg = await _roomService.Insert(model);
            if (msg.Length > 0) return BadRequest("Xảy ra lỗi! Vui lòng kiểm ta thông tin nhập vào và thực hiện lại");

            return Ok(msg);
        }

        [HttpPut]
        [Route("UpdateRoom")]
        public async Task<IActionResult> UpdateRoom([FromBody]Room model)
        {
            if (!ModelState.IsValid) return BadRequest("Dữ liệu đầu vào không hợp lệ");

            string msg = await _roomService.Update(model);
            if (msg.Length > 0) return BadRequest("Xảy ra lỗi! Vui lòng kiểm ta thông tin nhập vào và thực hiện lại");

            return Ok(msg);
        }

        [HttpDelete]
        [Route("DeleteRoom")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            if (id == 0) return BadRequest("Dữ liệu đầu vào không hợp lệ");

            string msg = await _roomService.Delete(id);
            if (msg.Length > 0) return BadRequest("Xảy ra lỗi! Vui lòng kiểm ta thông tin nhập vào và thực hiện lại");

            return Ok(msg);
        }
    }
}
