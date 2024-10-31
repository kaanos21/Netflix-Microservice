using Netflix.DtoLayer.ContentDtos.SeriesDto;

namespace Netflix.WebUı.Services.ContentServices.SeriesServices
{
    public class SeriesService : ISeriesService
    {
        private readonly HttpClient _httpClient;

        public SeriesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateSeriesAsync(CreateSeriesDto createSeriesDto)
        {
            await _httpClient.PostAsJsonAsync<CreateSeriesDto>("Series", createSeriesDto);
        }

        public async Task DeleteSeriesAsync(int id)
        {
            await _httpClient.DeleteAsync("Series?id=" + id);
        }

        public async Task<List<ResultSeriesDto>> GetAllSeriesAsync()
        {
            var responseMessage = await _httpClient.GetAsync("Series");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultSeriesDto>>();
            return values;
        }

        public async Task<UpdateSeriesDto> GetSeriesByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("Series/GetByIdSeries?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<UpdateSeriesDto>();
            return value;
        }

        public async Task<GetByIdSeriesDto> GetSeriesDetailByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("Series/GetSeriesDetailByIdAsync?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetByIdSeriesDto>();
            return value;
        }

        public async Task UpdateSeriesAsync(UpdateSeriesDto updateSeriesDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateSeriesDto>("Series", updateSeriesDto);
        }
    }
}
