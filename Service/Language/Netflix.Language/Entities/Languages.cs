namespace Netflix.Language.Entities
{
    public class Languages
    {
        public int LanguagesId { get; set; }
        public string LanguageName { get; set; }
        public List<Subtitles> Subtitles { get; set; }
    }
}
