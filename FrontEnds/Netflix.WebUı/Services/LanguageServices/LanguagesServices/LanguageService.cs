using Netflix.DtoLayer.LanguagesDtos.LanguagesDtos;

namespace Netflix.WebUı.Services.LanguageServices.LanguagesServices
{
    public class LanguageService:ILanguageService
    {
        private readonly HttpClient _httpClient;

        public LanguageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateLanguageAsync(CreateLanguagesDto createLanguageDto)
        {
            await _httpClient.PostAsJsonAsync<CreateLanguagesDto>("Language", createLanguageDto);
        }

        public async Task DeleteLanguageAsync(int id)
        {
            await _httpClient.DeleteAsync("Language?id=" + id);
        }

        public async Task<List<ResultLanguagesDto>> GetAllLanguageAsync()
        {
            var responseMessage = await _httpClient.GetAsync("Language");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultLanguagesDto>>();
            return values;
        }

        public async Task<GetByIdLanguagesDto> GetLanguageByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("Language/GetByIdLanguage?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetByIdLanguagesDto>();
            return value;
        }

        public async Task UpdateLanguageAsync(UpdateLanguagesDto updateLanguageDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateLanguagesDto>("Language", updateLanguageDto);
        }
    }
}
