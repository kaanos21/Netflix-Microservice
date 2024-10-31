using Netflix.DtoLayer.ContentDtos.SeasonDto;

namespace Netflix.WebUı.Services.ContentServices.SeasonService
{
    public class SeasonService : ISeasonService
    {
        private readonly HttpClient _httpClient;

        public SeasonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateSeasonAsync(CreateSeasonDto createSeasonDto)
        {
            await _httpClient.PostAsJsonAsync<CreateSeasonDto>("Season", createSeasonDto);
        }

        public async Task DeleteSeasonAsync(int id)
        {
            await _httpClient.DeleteAsync("Season?id=" + id);
        }

        public async Task<List<ResultSeasonDto>> GetAllSeasonAsync()
        {
            var responseMessage = await _httpClient.GetAsync("Season");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultSeasonDto>>();
            return values;
        }

        public async Task<GetByIdSeasonDto> GetSeasonByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("Season/GetByIdSeason?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetByIdSeasonDto>();
            return value;
        }

        public async Task UpdateSeasonAsync(UpdateSeasonDto updateSeasonDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateSeasonDto>("Season", updateSeasonDto);
        }


        public async Task<List<SeasonWithSeriesNameDto>> GetListSeasonWithSeriesNameBySeriesId(int seriesId)
        {
            var responseMessage = await _httpClient.GetAsync("Season/GetListSeasonWithSeriesNameBySeriesId?id=" + seriesId);
            var value=await responseMessage.Content.ReadFromJsonAsync<List<SeasonWithSeriesNameDto>>();
            return value;
        }

        
    }
}
