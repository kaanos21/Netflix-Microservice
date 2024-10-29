using Netflix.Movie.Dtos.MoviesDtos;

namespace Netflix.Movie.Services.MovieServices
{
    public interface IMovieManager
    {
        Task<List<ResultMovieDto>> GetAllMovieAsync();
        Task<GetByIdMovieDto> GetMovieByIdAsync(int id);
        Task CreateMovieAsync(CreateMovieDto MovieDto);
        Task UpdateMovieAsync(UpdateMovieDto MovieDto);
        Task DeleteMovieAsync(int id);
    }
}
