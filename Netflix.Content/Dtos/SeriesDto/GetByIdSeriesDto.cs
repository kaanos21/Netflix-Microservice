namespace Netflix.Content.Dtos.SeriesDto
{
    public class GetByIdSeriesDto
    {
        public int SeriesId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int TotalSeasons { get; set; }
    }
}
