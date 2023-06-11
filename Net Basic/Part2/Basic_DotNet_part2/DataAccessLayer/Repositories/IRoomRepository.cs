using WebApplication1.Entities;

namespace WebApplication1.DataAccessLayer.Repositories {
    public interface IRoomRepository {
        public Task<Room> AddAsync(Room room);

        public Task<Room> GetByIdAsync(int id);

        public Task<List<Room>> GetAllAsync();

        public Task UpdateAsync(Room room);

        public Task DeleteAsync(Room room);
    }
}
