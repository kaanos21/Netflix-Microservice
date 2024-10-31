using Netflix.DtoLayer.CommentDtos.CommentsDtos;

namespace Netflix.WebUı.Services.CommentServices.CommentsServices
{
    public class CommentServices:ICommentServices
    {
        private readonly HttpClient _httpClient;

        public CommentServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateCommentAsync(CreateCommentsDto createCommentsDto)
        {
            await _httpClient.PostAsJsonAsync<CreateCommentsDto>("Comment", createCommentsDto);
        }

        public async Task DeleteCommentAsync(int id)
        {
            await _httpClient.DeleteAsync("Comment?id=" + id);
        }

        public async Task<List<ResultCommentsDto>> GetAllCommentAsync()
        {
            var responseMessage = await _httpClient.GetAsync("Comment");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultCommentsDto>>();
            return values;
        }

        public async Task<GetByIdCommentsDto> GetCommentByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("Comment/GetByIdComment?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetByIdCommentsDto>();
            return value;
        }

        public async Task<List<ResultCommentsDto>> GetCommentListByContentIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync("Comment/GetCommentListByContentIdAsync?id="+id);
            var value = await responseMessage.Content.ReadFromJsonAsync<List<ResultCommentsDto>>();
            return value;
        }

        public async Task UpdateCommentAsync(UpdateCommentsDto updateCommentsDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateCommentsDto>("Comment", updateCommentsDto);
        }
    }
}
