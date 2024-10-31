using Microsoft.AspNetCore.Mvc;
using Netflix.Comment.Dtos.CommentDtos;
using Netflix.Comment.Services.CommentServices;

namespace Netflix.Comment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentManager _CommentManager;

        public CommentController(ICommentManager CommentManager)
        {
            _CommentManager = CommentManager;
        }
        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentsDto createCommentDto)
        {
            await _CommentManager.CreateCommentAsync(createCommentDto);
            return Ok("başarı ile eklendi");
        }
        [HttpGet]
        public async Task<IActionResult> GetListComment()
        {
            var value = await _CommentManager.GetAllCommentAsync();
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentsDto updateCommentDto)
        {
            await _CommentManager.UpdateCommentAsync(updateCommentDto);
            return Ok("başarı ile güncellendi");
        }
        [HttpGet("GetByIdComment")]
        public async Task<IActionResult> GetByIdComment(int id)
        {
            var value = await _CommentManager.GetCommentByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteComment(int id)
        {
            await _CommentManager.DeleteCommentAsync(id);
            return Ok("Silindi");
        }
        [HttpGet("GetCommentListByContentIdAsync")]
        public async Task<IActionResult> GetCommentListByContentIdAsync(int id)
        {
            var value=await _CommentManager.GetCommentListByContentIdAsync(id);
            return Ok(value);
        }
    }
}
