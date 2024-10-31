namespace Netflix.Content.Entities
{
    public class Season
    {

        public int SeasonId { get; set; } // Sezon ID
        public int SeriesId { get; set; } // Hangi diziye ait olduğu
        public string SeasonName { get; set; } 
        public int SeasonNumber { get; set; } // Sezon numarası
        public int EpisodeCount { get; set; } // Toplam bölüm sayısı

        // İlişki: Bir sezon birden fazla bölüme sahip olabilir
        public List<Episode> Episodes { get; set; } = new List<Episode>();
        public Series Series { get; set; }
    }
}
