namespace WebApplication1.Entities {
    public class Reservation : BaseEntity {
        public string CustomerName { get; set; } = default!;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Room Room { get; set; } = default!;
        public int RoomId { get; set; }
    }
}
