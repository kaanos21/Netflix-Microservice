namespace Netflix.Genre.Entitites
{
    public class Genres
    {
        public int GenresId { get; set; }
        public string Name { get; set; } 
        public List<GenreMappings> GenreMappings { get; set; } // İlişkili GenreMapping nesneleri
    }
}
