using Netflix.DtoLayer.GenreDtos.GenreMappingDtos;

namespace Netflix.WebUı.Services.GenreServices.GenreMappingServices
{
    public interface IGenreMappingService
    {
        Task<List<ResultGenreMappingDto>> GetAllGenreMappingAsync();
        Task<GetByIdGenreMappingDto> GetGenreMappingByIdAsync(int id);
        Task CreateGenreMappingAsync(CreateGenreMappingDto GenreMappingDto);
        Task UpdateGenreMappingAsync(UpdateGenreMappingDto GenreMappingDto);
        Task DeleteGenreMappingAsync(int id);
        Task<List<GetByContentIdGenreListWithNameDto>> GetGenreListWithGenreNameByContentId(int contentId);
    }
}
