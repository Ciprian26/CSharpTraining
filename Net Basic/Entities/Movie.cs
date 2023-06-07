namespace Net_Basic.Entities {
    public class Movie {
        public int MovieId { get; set; }
        public string Title { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string Director { get; set; } = string.Empty;
        public List<MovieGenre>? Genres { get; set; }
        public List<MovieActor>? Actors { get; set; }
    }
}
