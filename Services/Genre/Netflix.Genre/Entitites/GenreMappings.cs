namespace Netflix.Genre.Entitites
{
    public class GenreMappings
    {
        public int GenreMappingsId { get; set; }
        public int ContentId { get; set; } // İçerik ID'si
        public int GenresId { get; set; } // Genre ID'si

        public Genres Genre { get; set; } // İlişkilendirilmiş Genre nesnesi
    }
}
