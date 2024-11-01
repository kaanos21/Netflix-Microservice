using Netflix.Genre.Dtos.GenreMappingDtos;

namespace Netflix.GenreMapping.Services.GenreMappingMappingServices
{
    public interface IGenreMappingMappingManager
    {
        Task<List<ResultGenreMappingDto>> GetAllGenreMappingAsync();
        Task<GetByIdGenreMappingDto> GetGenreMappingByIdAsync(int id);
        Task CreateGenreMappingAsync(CreateGenreMappingDto GenreMappingDto);
        Task UpdateGenreMappingAsync(UpdateGenreMappingDto GenreMappingDto);
        Task DeleteGenreMappingAsync(int id);
        Task<List<GetByContentIdGenreListWithNameDto>> GetGenreListWithGenreNameByContentId(int contentId);
    }
}
