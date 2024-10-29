using Netflix.Genre.Dtos.GenresDtos;

namespace Netflix.Genre.Services.GenresServices
{
    public interface IGenresManager
    {
        Task<List<ResultGenresDto>> GetAllGenreAsync();
        Task<GetByIdGenresDto> GetGenreByIdAsync(int id);
        Task CreateGenreAsync(CreateGenresDto GenreDto);
        Task UpdateGenreAsync(UpdateGenresDto GenreDto);
        Task DeleteGenreAsync(int id);
    }
}
