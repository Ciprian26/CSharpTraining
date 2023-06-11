namespace WebApplication1.DataTransferObject
{
    public class HotelDto
    {
        public string Name { get; set; } = default!;
        public int Stars { get; set; }
        public string Country { get; set; } = default!;
        public string City { get; set; } = default!;
        public string? Description { get; set; }
    }
}
