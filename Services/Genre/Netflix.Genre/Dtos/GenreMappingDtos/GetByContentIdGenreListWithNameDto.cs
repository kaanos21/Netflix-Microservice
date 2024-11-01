namespace Netflix.Genre.Dtos.GenreMappingDtos
{
    public class GetByContentIdGenreListWithNameDto
    {
        public int GenreMappingId { get; set; }
        public int ContentId { get; set; }
        public int GenresId { get; set; }
        public string GenreName { get; set; }
    }
}
