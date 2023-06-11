namespace WebApplication1.DataAccessLayer.Repositories {
    using WebApplication1.Entities;

    public interface IHotelRepository {
        public Task<Hotel> AddAsync(Hotel hotel);

        public Task<Hotel> GetByIdAsync(int id);

        public Task<List<Hotel>> GetAllAsync();

        public Task UpdateAsync(Hotel hotel);

        public Task DeleteAsync(Hotel hotel);

        public Task<List<Hotel>> GetAllActiveHotels();
    }
}
