using Netflix.Content.Dtos.SeriesDto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Netflix.Content.Services.SeriesServices
{
    public interface ISeriesManager
    {
        Task<List<ResultSeriesDto>> GetAllSeriesAsync();
        Task<UpdateSeriesDto> GetSeriesByIdAsync(int id);
        Task<GetByIdSeriesDto> GetSeriesDetailByIdAsync(int id);
        Task CreateSeriesAsync(CreateSeriesDto seriesDto);
        Task UpdateSeriesAsync(UpdateSeriesDto seriesDto);
        Task DeleteSeriesAsync(int id);
    }
}
