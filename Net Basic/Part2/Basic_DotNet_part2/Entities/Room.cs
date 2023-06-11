using System.Security.Principal;

namespace WebApplication1.Entities {
    public class Room : BaseEntity {
        public int Number { get; set; }
        public int HotelId { get; set; }
        public Reservation Reservation { get; set; } = default!;
    }
}
