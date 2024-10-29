namespace Netflix.Movie.Dtos.MoviesDtos
{
    public class CreateMovieDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
    }
}
