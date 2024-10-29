
using Netflix.Language.Dtos.SubtitleDtos;

namespace Netflix.Subtitle.Services.SubtitleService
{
    public interface ISubtitleService
    {
        Task<List<ResultSubtitleDto>> GetAllSubtitleAsync();
        Task<GetByIdSubtitleDto> GetSubtitleByIdAsync(int id);
        Task CreateSubtitleAsync(CreateSubtitleDto SubtitleDto);
        Task UpdateSubtitleAsync(UpdateSubtitleDto SubtitleDto);
        Task DeleteSubtitleAsync(int id);
    }
}
