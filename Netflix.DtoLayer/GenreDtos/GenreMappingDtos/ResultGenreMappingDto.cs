namespace Netflix.DtoLayer.GenreDtos.GenreMappingDtos
{
    public class ResultGenreMappingDto
    {
        public int GenreMappingId { get; set; }
        public int ContentId { get; set; } // İçerik ID'si
        public int GenresId { get; set; } // Genre ID'si
    }
}
