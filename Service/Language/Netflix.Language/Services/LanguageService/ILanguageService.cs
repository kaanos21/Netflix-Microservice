using Netflix.Language.Dtos.LanguageDtos;

namespace Netflix.Language.Services.LanguageService
{
    public interface ILanguageService
    {
        Task<List<ResultLanguagesDto>> GetAllLanguageAsync();
        Task<GetByIdLanguagesDto> GetLanguageByIdAsync(int id);
        Task CreateLanguageAsync(CreateLanguagesDto LanguageDto);
        Task UpdateLanguageAsync(UpdateLanguagesDto LanguageDto);
        Task DeleteLanguageAsync(int id);
    }
}
