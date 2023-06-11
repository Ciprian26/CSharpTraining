using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApiApplication.Controllers
{
    using System.Text;
    using System.Text.Json;

    using WebApplication1.DataTransferObject;

    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly HttpClient httpClient;

        public TestController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        [HttpPost]
        [Route("MakeHttpRequest")]
        public async Task<ActionResult> MakeHttpRequest([FromBody] HotelDto hotel)
        {
            this.httpClient.BaseAddress = new Uri("https://localhost:7256/");

            var url = "https://localhost:7256/api/hotels/CreateHotel";

            var serializedHotel = JsonSerializer.Serialize(hotel);

            var stringContent = new StringContent(serializedHotel, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(url, stringContent);

            return this.Ok();
        }
    }
}
