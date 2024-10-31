using Netflix.DtoLayer.ContentDtos.EpisodeDto;

namespace Netflix.WebUı.Services.ContentServices.EpisodeServices
{
    public class EpisodeService : IEpisodeService
    {
        private readonly HttpClient _httpClient;

        public EpisodeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateEpisodeAsync(CreateEpisodeDto createEpisodeDto)
        {
             await _httpClient.PostAsJsonAsync<CreateEpisodeDto>("episode", createEpisodeDto); 
        }

        public async Task DeleteEpisodeAsync(int id)
        {
            await _httpClient.DeleteAsync("episode?id=" + id);
        }

        public async Task<List<ResultEpisodeDto>> GetAllEpisodeAsync()
        {
            var responseMessage = await _httpClient.GetAsync("Episode");
            var values=await responseMessage.Content.ReadFromJsonAsync<List<ResultEpisodeDto>>();
            return values;
        }

        public async Task<UpdateEpisodeDto> GetEpisodeByIdAsync(int id)
        {
           var responseMessage= await _httpClient.GetAsync("Episode/GetByIdEpisode?id="+id);
           var value=await responseMessage.Content.ReadFromJsonAsync<UpdateEpisodeDto>();
            return value;
        }

        public async Task<GetByIdEpisodeDto> GetEpisodeDetailByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("Episode/GetByIdEpisode?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetByIdEpisodeDto>();
            return value;
        }

        public async Task<List<EpisodeListWithSeriesNameAndSeasonNameBySeriesId>> GetEpisodeListDetail(int seasonId)
        {
            //Episode/GetEpisodeListDetail?seasonId=3
            var responseMessage = await _httpClient.GetAsync("Episode/GetEpisodeListDetail?seasonId=" + seasonId);
            var value = await responseMessage.Content.ReadFromJsonAsync<List<EpisodeListWithSeriesNameAndSeasonNameBySeriesId>>();
            return value;
        }

        public async Task<List<ResultEpisodeDto>> GetEpisodesListBySeasonId(int seasonId)
        {
            var responseMessage = await _httpClient.GetAsync("Episode/GetEpisodesListBySeasonId?id="+seasonId);
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultEpisodeDto>>();
            return values;
        }

        public async Task UpdateEpisodeAsync(UpdateEpisodeDto updateEpisodeDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateEpisodeDto>("episode", updateEpisodeDto);
        }
    }
}
