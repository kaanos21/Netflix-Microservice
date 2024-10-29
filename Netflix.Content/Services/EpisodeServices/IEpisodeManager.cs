using Netflix.Content.Dtos.EpisodeDto;

namespace Netflix.Content.Services.EpisodeServices
{
    public interface IEpisodeManager
    {
        Task<List<ResultEpisodeDto>> GetAllEpisodeAsync();
        Task<GetByIdEpisodeDto> GetEpisodeByIdAsync(int id);
        Task CreateEpisodeAsync(CreateEpisodeDto EpisodeDto);
        Task UpdateEpisodeAsync(UpdateEpisodeDto EpisodeDto);
        Task DeleteEpisodeAsync(int id);
    }
}
