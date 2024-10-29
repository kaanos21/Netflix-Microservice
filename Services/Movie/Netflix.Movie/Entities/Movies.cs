namespace Netflix.Movie.Entities
{
    public class Movies
    {
        public int MoviesId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
        public string StreamFileUrl { get; set; }
    }
}
