namespace Netflix.DtoLayer.ContentDtos.SeriesDto
{
    public class CreateSeriesDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int TotalSeasons { get; set; }
    }
}
