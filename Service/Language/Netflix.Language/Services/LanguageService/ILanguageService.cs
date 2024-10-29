using Netflix.Language.Dtos.LanguageDtos;

namespace Netflix.Language.Services.LanguageService
{
    public interface ILanguageService
    {
        Task<List<ResultLanguageDto>> GetAllLanguageAsync();
        Task<GetByIdLanguageDto> GetLanguageByIdAsync(int id);
        Task CreateLanguageAsync(CreateLanguageDto LanguageDto);
        Task UpdateLanguageAsync(UpdateLanguageDto LanguageDto);
        Task DeleteLanguageAsync(int id);
    }
}
