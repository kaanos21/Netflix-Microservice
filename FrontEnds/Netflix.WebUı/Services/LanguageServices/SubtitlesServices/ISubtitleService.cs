using Netflix.DtoLayer.LanguagesDtos.SubtitleDtos;


namespace Netflix.WebUı.Services.LanguageServices.SubtitlesServices
{
    public interface ISubtitleService
    {
        Task<List<ResultSubtitleDto>> GetAllSubtitleAsync();
        Task<GetByIdSubtitleDto> GetSubtitleByIdAsync(int id);
        Task CreateSubtitleAsync(CreateSubtitleDto SubtitleDto);
        Task UpdateSubtitleAsync(UpdateSubtitleDto SubtitleDto);
        Task DeleteSubtitleAsync(int id);
        Task<List<GetSubtitlesWithLanguageByContentIdDto>> GetSubtitlesWithLanguageByContentId(int contentId);
    }
}
