using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Netflix.DtoLayer.CommentDtos.CommentsDtos;
using Netflix.WebUı.Services.CommentServices.CommentsServices;

namespace Netflix.WebUı.ViewComponents.CommentViewComponents
{
    public class _CreateCommentViewComponents : ViewComponent
    {
        private readonly ICommentServices _commentServices;

        public _CreateCommentViewComponents(ICommentServices commentServices)
        {
            _commentServices = commentServices;
        }
        public async Task<IViewComponentResult> InvokeAsync(int contentId)
        {
            var model = new CreateCommentsDto { ContentId = contentId };
            return View(model);
        }
    }
}
