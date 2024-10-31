namespace Netflix.DtoLayer.LanguagesDtos.SubtitleDtos
{
    public class GetByIdSubtitleDto
    {
        public int SubtitlesId { get; set; }
        public int ContentId { get; set; }
        public int LanguageId { get; set; }
        public string SubtitleFileUrl { get; set; }
    }
}
