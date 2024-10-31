using Netflix.DtoLayer.LanguagesDtos.SubtitleDtos;


namespace Netflix.WebUı.Services.LanguageServices.SubtitlesServices
{
    public class SubtitleService:ISubtitleService
    {
        private readonly HttpClient _httpClient;

        public SubtitleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateSubtitleAsync(CreateSubtitleDto createSubtitleDto)
        {
            await _httpClient.PostAsJsonAsync<CreateSubtitleDto>("Subtitle", createSubtitleDto);
        }

        public async Task DeleteSubtitleAsync(int id)
        {
            await _httpClient.DeleteAsync("Subtitle?id=" + id);
        }

        public async Task<List<ResultSubtitleDto>> GetAllSubtitleAsync()
        {
            var responseMessage = await _httpClient.GetAsync("Subtitle");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultSubtitleDto>>();
            return values;
        }

        public async Task<GetByIdSubtitleDto> GetSubtitleByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("Subtitle/GetByIdSubtitle?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetByIdSubtitleDto>();
            return value;
        }

        public async Task<List<GetSubtitlesWithLanguageByContentIdDto>> GetSubtitlesWithLanguageByContentId(int contentId)
        {
            var responseMessage = await _httpClient.GetAsync("Subtitle/GetSubtitlesWithLanguageByContentId?contentId=" + contentId);
            var value = await responseMessage.Content.ReadFromJsonAsync<List<GetSubtitlesWithLanguageByContentIdDto>>();
            return value;
        }

        public async Task UpdateSubtitleAsync(UpdateSubtitleDto updateSubtitleDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateSubtitleDto>("Subtitle", updateSubtitleDto);
        }
    }
}
