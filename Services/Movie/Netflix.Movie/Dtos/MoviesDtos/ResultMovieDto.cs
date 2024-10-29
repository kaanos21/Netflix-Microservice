namespace Netflix.Movie.Dtos.MoviesDtos
{
    public class ResultMovieDto
    {
        public int MoviesId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
    }
}
