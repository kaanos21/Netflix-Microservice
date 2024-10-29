namespace Netflix.Content.Entities
{
    public class Series
    {
        public int SeriesId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int TotalSeasons { get; set; }

        // İlişki: Bir dizi birden fazla sezona sahip olabilir
        public List<Season> Seasons { get; set; } = new List<Season>();
    }
}
