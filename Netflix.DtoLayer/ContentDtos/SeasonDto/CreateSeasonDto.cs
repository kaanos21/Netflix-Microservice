namespace Netflix.DtoLayer.ContentDtos.SeasonDto
{

    public class CreateSeasonDto
    {
        public int SeriesId { get; set; } // Hangi diziye ait olduğu
        public int SeasonNumber { get; set; } // Sezon numarası
        public string SeasonName { get; set; }
        public int EpisodeCount { get; set; } // Toplam bölüm sayısı
    }
}
