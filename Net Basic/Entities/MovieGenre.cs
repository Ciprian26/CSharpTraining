using System.ComponentModel.DataAnnotations;

namespace Net_Basic.Entities {
    public class MovieGenre {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string? Genre { get; set; }
        public Movie? Movie { get; set; }
    }
}
