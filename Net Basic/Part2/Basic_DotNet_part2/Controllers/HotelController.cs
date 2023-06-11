using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers {
    using WebApplication1.DataTransferObject;
    using WebApplication1.Exceptions;
    using WebApplication1.Services;

    [ApiController]
    [Route("api/hotels")]
    public class HotelController : ControllerBase {
        private readonly IHotelService hotelService;

        public HotelController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        // Create new hotel method
        [HttpPost]
        [Route("CreateHotel")]
        public async Task<IActionResult> CreateHotel([FromBody] HotelDto hotelDto)
        {
            await this.hotelService.AddHotel(hotelDto);

            return this.Ok();
        }

        // Update hotel by id
        // If entity is deleted, this endpoint will reactivate it 
        // Doesn't check if the hotel exists. In such case, makes a new hotel
        // TODO: Reject updating if isDeleted = 1 and make another endpoint to reactivate it
        [HttpPut]
        [Route("UpdateHotelById")] // api/hotel/1
        public async Task<IActionResult> UpdateHotel(int id, [FromBody] HotelDto hotelDto)
        {
            var updatedHotel = await this.hotelService.UpdateHotel(id, hotelDto);

            return this.Ok(updatedHotel);
        }

        // Get a specific hotel based on id
        [HttpGet]
        [Route("GetHotelById")]  // api/hotel/1
        public async Task<IActionResult> GetHotelById(int id)
        {
            try
            {
                var hotel = await this.hotelService.GetHotelById(id);
                return this.Ok(hotel);
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

        // Get all active hotels
        [HttpGet]
        [Route("GetAllActiveHotels")]  // api/getallactivehotels
        public async Task<IActionResult> GetAllActiveHotels()
        {
            var restultHotels = await this.hotelService.GetAllActiveHotels();
            if (restultHotels.Count == 0)
            {
                return this.NoContent();
            }
            return this.Ok(restultHotels);
        }

        // Delete a specific hotel
        [HttpDelete]
        [Route("DeleteHotel")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            try
            {
                await this.hotelService.RemoveHotelById(id);

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

        //// Get all hotels
        //[HttpGet]
        //public async Task<IActionResult> GetAllHotels()
        //{
        //    var hotels = await _dbContext.Hotels.ToListAsync();

        //    return Ok(hotels);
        //}

        //// Get hotels with rooms
        //[HttpGet]
        //[Route("rooms")] //api/hotels/rooms
        //public async Task<IActionResult> GetHotelsWithRooms()
        //{
        //    var hotels = await _dbContext.Hotels.Include(h => h.Rooms).ToListAsync();

        //    return Ok(hotels);
        //}

        //// Update a specific hotel
        //[HttpPut]
        //public async Task<IActionResult> UpdateHotel(int hotelId, [FromBody] Hotel hotelUpdated)
        //{
        //    var hotel = await _dbContext.Hotels.FirstOrDefaultAsync(h => h.Id == hotelId);

        //    // check if the hotel is null and return Not found
        //    if (hotel is null) // hotel == null
        //    {
        //        return NotFound($"The hotel with id {hotelId} does not exists.");
        //    }

        //    hotel.Stars = hotelUpdated.Stars;
        //    hotel.Name = hotelUpdated.Name;
        //    hotel.City = hotelUpdated.City;

        //    _dbContext.Hotels.Update(hotel);
        //    await _dbContext.SaveChangesAsync();

        //    return NoContent();
        //}
    }
}
