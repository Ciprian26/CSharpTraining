using WebApplication1.DataTransferObject;

namespace WebApplication1.Services {
    public interface IRoomService {
        public Task AddRoom(RoomDto roomDto);

        public Task<RoomDto> GetRoomById(int id);

        public Task RemoveRoomById(int id);

        public Task<RoomDto> UpdateRoom(int Id, RoomDto roomDto);
    }
}
