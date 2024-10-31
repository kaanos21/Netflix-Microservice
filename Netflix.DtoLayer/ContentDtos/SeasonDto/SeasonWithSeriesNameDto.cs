namespace Netflix.DtoLayer.ContentDtos.SeasonDto
{
    public class SeasonWithSeriesNameDto
    {
        public int SeasonId { get; set; } // Sezon ID
        public int SeriesId { get; set; } // Hangi diziye ait olduğu
        public string SeasonName { get; set; }
        public int SeasonNumber { get; set; } // Sezon numarası
        public int EpisodeCount { get; set; } // Toplam bölüm sayısı
        public string SeriesName { get; set; } // Dizi adı
    }
}
