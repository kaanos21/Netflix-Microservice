namespace Netflix.Genre.Dtos.GenreMappingDtos
{
    public class UpdateGenreMappingDto
    {
        public int GenreMappingId { get; set; }
        public int ContentId { get; set; } // İçerik ID'si
        public int GenresId { get; set; } // Genre ID'si
    }
}
