using Netflix.Content.Dtos.SeasonDto;

namespace Netflix.Content.Services.SeasonServices
{
    public interface ISeasonManager
    {
        Task<List<ResultSeasonDto>> GetAllSeasonAsync();
        Task<GetByIdSeasonDto> GetSeasonByIdAsync(int id);
        Task CreateSeasonAsync(CreateSeasonDto SeasonDto);
        Task UpdateSeasonAsync(UpdateSeasonDto SeasonDto);
        Task DeleteSeasonAsync(int id);
        Task<List<SeasonWithSeriesNameDto>> GetListSeasonWithSeriesNameBySeriesId(int seriesId);
    }
}
