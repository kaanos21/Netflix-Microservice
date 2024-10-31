using Netflix.DtoLayer.MovieDtos.MoviesDtos;

namespace Netflix.WebUı.Services.MovieService.MoviesService
{
    public interface IMovieService
    {
        Task<List<ResultMovieDto>> GetAllMovieAsync();
        Task<GetByIdMovieDto> GetMovieByIdAsync(int id);
        Task CreateMovieAsync(CreateMovieDto MovieDto);
        Task UpdateMovieAsync(UpdateMovieDto MovieDto);
        Task DeleteMovieAsync(int id);
    }
}
