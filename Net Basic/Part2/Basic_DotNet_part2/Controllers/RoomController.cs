using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers {
    using WebApplication1.DataTransferObject;
    using WebApplication1.Exceptions;
    using WebApplication1.Services;

    [ApiController]
    [Route("api/rooms")]
    public class RoomController : ControllerBase {
        private readonly IRoomService roomService;

        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        // Create new room method
        [HttpPost]
        [Route("CreateRoom")]
        public async Task<IActionResult> CreateRoom([FromBody] RoomDto roomDto)
        {
            await this.roomService.AddRoom(roomDto);

            return this.Ok();
        }

        [HttpGet]
        [Route("GetRoomById")] //api/room/1
        public async Task<IActionResult> GetRoomById(int id)
        {
            try
            {
                var room = await this.roomService.GetRoomById(id);
                return this.Ok(room);
            }
            catch (NotFoundException ex)
            {
                return this.NotFound(ex.Message);
            }
            catch (Exception ex)
            { return this.BadRequest(ex.Message); }
        }

        [HttpDelete]
        [Route("DeleteRoom")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            try
            {
                await this.roomService.RemoveRoomById(id);

                return this.Ok();
            }
            catch (NotFoundException ex)
            {
                return this.NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("UpdateRoom")]
        public async Task<IActionResult> UpdateRoom(int id, [FromBody] RoomDto roomDto)
        {
            var updatedRoom = await this.roomService.UpdateRoom(id, roomDto);

            return this.Ok(updatedRoom);
        }
    }
}
