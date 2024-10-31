using Netflix.DtoLayer.MovieDtos.MoviesDtos;

namespace Netflix.WebUı.Services.MovieService.MoviesService
{
    public class MovieService:IMovieService
    {
        private readonly HttpClient _httpClient;

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateMovieAsync(CreateMovieDto createMovieDto)
        {
            await _httpClient.PostAsJsonAsync<CreateMovieDto>("Movie", createMovieDto);
        }

        public async Task DeleteMovieAsync(int id)
        {
            await _httpClient.DeleteAsync("Movie?id=" + id);
        }

        public async Task<List<ResultMovieDto>> GetAllMovieAsync()
        {
            var responseMessage = await _httpClient.GetAsync("Movie");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultMovieDto>>();
            return values;
        }

        public async Task<GetByIdMovieDto> GetMovieByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("Movie/GetByIdMovie?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetByIdMovieDto>();
            return value;
        }

        public async Task UpdateMovieAsync(UpdateMovieDto updateMovieDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateMovieDto>("Movie", updateMovieDto);
        }
    }
}
