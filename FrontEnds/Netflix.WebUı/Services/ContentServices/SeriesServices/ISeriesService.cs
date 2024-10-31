using Netflix.DtoLayer.ContentDtos.SeriesDto;

namespace Netflix.WebUı.Services.ContentServices.SeriesServices
{
    public interface ISeriesService
    {
        Task<List<ResultSeriesDto>> GetAllSeriesAsync();
        Task<UpdateSeriesDto> GetSeriesByIdAsync(int id);
        Task<GetByIdSeriesDto> GetSeriesDetailByIdAsync(int id);
        Task CreateSeriesAsync(CreateSeriesDto seriesDto);
        Task UpdateSeriesAsync(UpdateSeriesDto seriesDto);
        Task DeleteSeriesAsync(int id);
    }
}
