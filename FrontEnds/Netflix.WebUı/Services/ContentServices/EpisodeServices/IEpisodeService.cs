using Netflix.DtoLayer.ContentDtos.EpisodeDto;

namespace Netflix.WebUı.Services.ContentServices.EpisodeServices
{
    public interface IEpisodeService
    {
        Task<List<ResultEpisodeDto>> GetAllEpisodeAsync();
        Task<UpdateEpisodeDto> GetEpisodeByIdAsync(int id);
        Task<GetByIdEpisodeDto> GetEpisodeDetailByIdAsync(int id);
        Task CreateEpisodeAsync(CreateEpisodeDto createEpisodeDto);
        Task UpdateEpisodeAsync(UpdateEpisodeDto updateEpisodeDto);
        Task DeleteEpisodeAsync(int id);
        Task<List<ResultEpisodeDto>> GetEpisodesListBySeasonId(int seasonId);
        Task<List<EpisodeListWithSeriesNameAndSeasonNameBySeriesId>> GetEpisodeListDetail(int seasonId);
    }
}
