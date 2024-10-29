using Netflix.Comment.Dtos.CommentDtos;

namespace Netflix.Comment.Services.CommentServices
{
    public interface ICommentManager
    {
        Task<List<ResultCommentDto>> GetAllCommentAsync();
        Task<GetByIdCommentDto> GetCommentByIdAsync(int id);
        Task CreateCommentAsync(CreateCommentDto CommentDto);
        Task UpdateCommentAsync(UpdateCommentDto CommentDto);
        Task DeleteCommentAsync(int id);
        Task <List<ResultCommentDto>> GetCommentListByContentIdAsync(int id);
    }
}
