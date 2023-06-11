using WebApplication1.DataTransferObject;

using WebApplication1.DataAccessLayer.Repositories;
using WebApplication1.DataTransferObject;
using WebApplication1.Entities;
using WebApplication1.Exceptions;

namespace WebApplication1.Services {
    public class RoomService : IRoomService {
        private readonly IRoomRepository roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }
        public async Task AddRoom(RoomDto roomDto)
        {
            var mappedData = this.MapRoomData(roomDto);
            await this.roomRepository.AddAsync(mappedData);
        }

        public async Task<RoomDto> GetRoomById(int id)
        {
            var room = await this.roomRepository.GetByIdAsync(id);
            if (room is null)
            {
                throw new NotFoundException($"The room with the given id: '{id}' was not found");
            }

            var mappedData = this.MapRoomData(room);
            return mappedData;
        }

        public async Task RemoveRoomById(int id)
        {
            var hotel = await this.roomRepository.GetByIdAsync(id);
            if (hotel is null)
            {
                throw new NotFoundException($"The room with the given id: '{id}' was not found");
            }

            await this.roomRepository.DeleteAsync(hotel);
        }

        public async Task<RoomDto> UpdateRoom(int id, RoomDto roomDto)
        {
            var updatedRoom = MapRoomData(id, roomDto);
            await this.roomRepository.UpdateAsync(updatedRoom);
            return MapRoomData(updatedRoom);
        }

        private Room MapRoomData(RoomDto roomDto)
        {
            return new Room
            {
                Number = roomDto.Number,
                HotelId = roomDto.HotelId
            };
        }

        private RoomDto MapRoomData(Room room)
        {
            return new RoomDto
            {
                Number = room.Number,
                HotelId = room.HotelId
            };
        }

        private Room MapRoomData(int id, RoomDto roomDto)
        {
            return new Room
            {
                Id = id,
                Number = roomDto.Number,
                HotelId = roomDto.HotelId
            };
        }
    }
}
