using Netflix.DtoLayer.GenreDtos.GenreMappingDtos;

namespace Netflix.WebUı.Services.GenreServices.GenreMappingServices
{
    public class GenreMappingService:IGenreMappingService
    {
        private readonly HttpClient _httpClient;

        public GenreMappingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateGenreMappingAsync(CreateGenreMappingDto createGenreMappingDto)
        {
            await _httpClient.PostAsJsonAsync<CreateGenreMappingDto>("GenreMapping", createGenreMappingDto);
        }

        public async Task DeleteGenreMappingAsync(int id)
        {
            await _httpClient.DeleteAsync("GenreMapping?id=" + id);
        }

        public async Task<List<ResultGenreMappingDto>> GetAllGenreMappingAsync()
        {
            var responseMessage = await _httpClient.GetAsync("GenreMapping");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultGenreMappingDto>>();
            return values;
        }

        public async Task<GetByIdGenreMappingDto> GetGenreMappingByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("GenreMapping/GetByIdGenreMapping?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetByIdGenreMappingDto>();
            return value;
        }

        public async Task UpdateGenreMappingAsync(UpdateGenreMappingDto updateGenreMappingDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateGenreMappingDto>("GenreMapping", updateGenreMappingDto);
        }
    }
}
