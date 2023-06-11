namespace WebApplication1.Entities {
    public class Hotel : BaseEntity {
        public string Name { get; set; } = default!;
        public int Stars { get; set; }
        public string Country { get; set; } = default!;
        public string City { get; set; } = default!;
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}
