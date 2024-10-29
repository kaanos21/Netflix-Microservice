namespace Netflix.Language.Entities
{
    public class Subtitles
    {
        public int SubtitlesId { get; set; }
        public int ContentId { get; set; }
        public int LanguageId { get; set; }
        public string SubtitleFileUrl { get; set; }
        public Languages Language { get; set; }
    }
}
