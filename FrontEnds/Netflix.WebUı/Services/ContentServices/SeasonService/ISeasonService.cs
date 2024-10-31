using Netflix.DtoLayer.ContentDtos.SeasonDto;

namespace Netflix.WebUı.Services.ContentServices.SeasonService
{
    public interface ISeasonService
    {
        Task<List<ResultSeasonDto>> GetAllSeasonAsync();
        Task<GetByIdSeasonDto> GetSeasonByIdAsync(int id);
        Task CreateSeasonAsync(CreateSeasonDto SeasonDto);
        Task UpdateSeasonAsync(UpdateSeasonDto SeasonDto);
        Task DeleteSeasonAsync(int id);
        Task<List<SeasonWithSeriesNameDto>> GetListSeasonWithSeriesNameBySeriesId(int seriesId);
    }
}
