using Netflix.DtoLayer.GenreDtos.GenresDtos;

namespace Netflix.WebUı.Services.GenreServices.GenreServicess
{
    public class GenreService:IGenreService
    {
        private readonly HttpClient _httpClient;

        public GenreService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateGenreAsync(CreateGenresDto createGenreDto)
        {
            await _httpClient.PostAsJsonAsync<CreateGenresDto>("Genre", createGenreDto);
        }

        public async Task DeleteGenreAsync(int id)
        {
            await _httpClient.DeleteAsync("Genre?id=" + id);
        }

        public async Task<List<ResultGenresDto>> GetAllGenreAsync()
        {
            var responseMessage = await _httpClient.GetAsync("Genre");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultGenresDto>>();
            return values;
        }

        public async Task<GetByIdGenresDto> GetGenreByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("Genre/GetByIdGenre?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetByIdGenresDto>();
            return value;
        }

        public async Task UpdateGenreAsync(UpdateGenresDto updateGenreDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateGenresDto>("Genre", updateGenreDto);
        }
    }
}
