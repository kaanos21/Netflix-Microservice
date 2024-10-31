using Netflix.Comment.Dtos.CommentDtos;

namespace Netflix.Comment.Services.CommentServices
{
    public interface ICommentManager
    {
        Task<List<ResultCommentsDto>> GetAllCommentAsync();
        Task<GetByIdCommentsDto> GetCommentByIdAsync(int id);
        Task CreateCommentAsync(CreateCommentsDto CommentDto);
        Task UpdateCommentAsync(UpdateCommentsDto CommentDto);
        Task DeleteCommentAsync(int id);
        Task <List<ResultCommentsDto>> GetCommentListByContentIdAsync(int id);
    }
}
