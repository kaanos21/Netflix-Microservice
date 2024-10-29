namespace Netflix.Content.Dtos.SeasonDto
{
    public class CreateSeasonDto
    {
        public int SeriesId { get; set; } // Hangi diziye ait olduğu
        public int SeasonNumber { get; set; } // Sezon numarası
        public int EpisodeCount { get; set; } // Toplam bölüm sayısı
    }
}
