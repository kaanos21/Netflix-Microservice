using Microsoft.AspNetCore.Mvc;
using Netflix.DtoLayer.CommentDtos.CommentsDtos;
using Netflix.WebUı.Services.CommentServices.CommentsServices;

namespace Netflix.WebUı.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentServices _Commentservices;

        public CommentController(ICommentServices commentservices)
        {
            _Commentservices = commentservices;
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentsDto createCommentsDto)
        {
            createCommentsDto.Date = DateTime.Now;
            await _Commentservices.CreateCommentAsync(createCommentsDto);
            return RedirectToAction("SeriesList", "Series");
        }
    }
}
