namespace WebApplication1.DataAccessLayer.Repositories {
    using Microsoft.EntityFrameworkCore;

    using WebApplication1.Entities;

    public class HotelRepository : IHotelRepository {
        private readonly DataContext dataContext;

        public HotelRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Hotel> AddAsync(Hotel hotel)
        {
            var createdHotelEntity = await this.dataContext.Hotels.AddAsync(hotel);
            await this.dataContext.SaveChangesAsync();

            return createdHotelEntity.Entity;
        }

        public async Task<Hotel> GetByIdAsync(int id)
        {
            return await this.dataContext.Hotels.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Hotel>> GetAllAsync()
        {
            return await this.dataContext.Hotels.ToListAsync();
        }

        public async Task UpdateAsync(Hotel hotel)
        {
            this.dataContext.Hotels.Update(hotel);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Hotel hotel)
        {
            this.dataContext.Hotels.Remove(hotel);
            await this.dataContext.SaveChangesAsync();
        }

        public async Task<List<Hotel>> GetAllActiveHotels()
        {
            return await this.dataContext.Hotels.Where(x => !x.IsDeleted).ToListAsync();
        }
    }
}
