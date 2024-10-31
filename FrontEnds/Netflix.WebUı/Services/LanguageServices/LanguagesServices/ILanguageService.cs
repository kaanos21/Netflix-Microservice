using Netflix.DtoLayer.LanguagesDtos.LanguagesDtos;

namespace Netflix.WebUı.Services.LanguageServices.LanguagesServices
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
