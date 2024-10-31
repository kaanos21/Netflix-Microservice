using Netflix.DtoLayer.CommentDtos.CommentsDtos;

namespace Netflix.WebUı.Services.CommentServices.CommentsServices
{
    public interface ICommentServices
    {
        Task<List<ResultCommentsDto>> GetAllCommentAsync();
        Task<GetByIdCommentsDto> GetCommentByIdAsync(int id);
        Task CreateCommentAsync(CreateCommentsDto CommentDto);
        Task UpdateCommentAsync(UpdateCommentsDto CommentDto);
        Task DeleteCommentAsync(int id);
        Task<List<ResultCommentsDto>> GetCommentListByContentIdAsync(int id);
    }
}
