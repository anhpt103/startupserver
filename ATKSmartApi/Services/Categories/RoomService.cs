using Microsoft.EntityFrameworkCore;
using ATKSmartApi.Data;
using ATKSmartApi.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ATKSmartApi.Services.Categories
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetAll();
        Task<Room> GetById(int id);
        Task<string> Insert(Room room);
        Task<string> Update(Room room);
        Task<string> Delete(int id);
    }

    public class RoomService : IRoomService
    {
        private readonly ATKSmartContext _dbContext;

        public RoomService(ATKSmartContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _dbContext.Rooms.ToListAsync();
        }

        public async Task<Room> GetById(int id)
        {
            return await _dbContext.Rooms.FirstOrDefaultAsync(x => x.RoomId == id);
        }

        public async Task<string> Insert(Room room)
        {
            string msg = "";
            try
            {
                await _dbContext.Rooms.AddAsync(room);
                if (_dbContext.SaveChanges() == 0) msg = "Xảy ra lỗi khi lưu dữ liệu";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        public async Task<string> Update(Room room)
        {
            string msg = "";
            try
            {
                var roomItem = await _dbContext.Rooms.AnyAsync(x => x.RoomId == room.RoomId);
                if (!roomItem) return "Không tìm thấy dữ liệu";

                _dbContext.Rooms.Update(room);
                if (_dbContext.SaveChanges() == 0) msg = "Xảy ra lỗi khi lưu dữ liệu";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        public async Task<string> Delete(int id)
        {
            string msg = "";
            try
            {
                var roomItem = await _dbContext.Rooms.FirstOrDefaultAsync(x => x.RoomId == id);
                if (roomItem == null) return "Không tìm thấy dữ liệu";

                _dbContext.Rooms.Remove(roomItem);
                if (_dbContext.SaveChanges() == 0) msg = "Xảy ra lỗi khi lưu dữ liệu";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
    }
}
