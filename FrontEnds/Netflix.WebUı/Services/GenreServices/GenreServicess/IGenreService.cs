using Netflix.DtoLayer.GenreDtos.GenresDtos;

namespace Netflix.WebUı.Services.GenreServices.GenreServicess
{
    public interface IGenreService
    {
        Task<List<ResultGenresDto>> GetAllGenreAsync();
        Task<GetByIdGenresDto> GetGenreByIdAsync(int id);
        Task CreateGenreAsync(CreateGenresDto GenreDto);
        Task UpdateGenreAsync(UpdateGenresDto GenreDto);
        Task DeleteGenreAsync(int id);
    }
}
