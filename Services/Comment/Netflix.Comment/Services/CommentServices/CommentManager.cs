using Netflix.Comment.Context;
using Netflix.Comment.Dtos.CommentDtos;
using Netflix.Comment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Netflix.Comment.Services.CommentServices
{
    public class CommentManager : ICommentManager
    {
        private readonly NetflixCommentDbContext _context;

        public CommentManager(NetflixCommentDbContext context)
        {
            _context = context;
        }

        public async Task CreateCommentAsync(CreateCommentsDto CommentDto)
        {
            var comment = new Comments
            {
                ContentId = CommentDto.ContentId,
                Name = CommentDto.Name,
                CommentText = CommentDto.CommentText,
                Date = CommentDto.Date
            };

            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCommentAsync(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                throw new KeyNotFoundException($"Yorum bulunamadı: {id}");
            }
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultCommentsDto>> GetAllCommentAsync()
        {
            var commentList = await _context.Comments.ToListAsync();

            var resultList = commentList.Select(s => new ResultCommentsDto
            {
                CommentsId = s.CommentsId,
                Name = s.Name,
                CommentText = s.CommentText,
                Date = s.Date
            }).ToList();

            return resultList;
        }

        public async Task<GetByIdCommentsDto> GetCommentByIdAsync(int id)
        {
            var value = await _context.Comments.FindAsync(id);
            if (value == null)
            {
                throw new KeyNotFoundException($"Yorum bulunamadı: {id}");
            }

            var result = new GetByIdCommentsDto
            {
                CommentsId = value.CommentsId,
                ContentId = value.ContentId,
                Name = value.Name,
                CommentText = value.CommentText,
                Date = value.Date
            };
            return result;
        }

        public async Task<List<ResultCommentsDto>> GetCommentListByContentIdAsync(int id)
        {
            var value=await _context.Comments.Where(x=>x.ContentId == id).ToListAsync();
            var resultList = value.Select(s => new ResultCommentsDto
            {
                CommentsId = s.CommentsId,
                Name = s.Name,
                CommentText = s.CommentText,
                Date = s.Date
            }).ToList();
            return resultList;
        }

        public async Task UpdateCommentAsync(UpdateCommentsDto CommentDto)
        {
            var comment = await _context.Comments.FindAsync(CommentDto.CommentsId);
            if (comment == null)
            {
                throw new KeyNotFoundException($"Yorum bulunamadı: {CommentDto.CommentsId}");
            }

            comment.Name = CommentDto.Name;
            comment.CommentText = CommentDto.CommentText;
            comment.Date = CommentDto.Date;

            await _context.SaveChangesAsync();
        }
    }
}
