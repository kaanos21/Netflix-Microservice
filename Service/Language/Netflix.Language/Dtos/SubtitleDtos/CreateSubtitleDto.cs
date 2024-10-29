namespace Netflix.Language.Dtos.SubtitleDtos
{
    public class CreateSubtitleDto
    {
        public int ContentId { get; set; }
        public int LanguageId { get; set; }
        public string SubtitleFileUrl { get; set; }
    }
}
