using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.DataAccessLayer.Repositories {
    public class RoomRepository : IRoomRepository {
        private readonly DataContext dataContext;

        public RoomRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Room> AddAsync(Room room)
        {
            var createdRoomEntity = await this.dataContext.Rooms.AddAsync(room);
            await this.dataContext.SaveChangesAsync();

            return createdRoomEntity.Entity;
        }

        public async Task<Room> GetByIdAsync(int id)
        {
            return await this.dataContext.Rooms.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Room>> GetAllAsync()
        {
            return await this.dataContext.Rooms.ToListAsync();
        }

        public async Task UpdateAsync(Room room)
        {
            this.dataContext.Rooms.Update(room);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Room room)
        {
            this.dataContext.Rooms.Remove(room);
            await this.dataContext.SaveChangesAsync();
        }
    }
}
