using Microsoft.AspNetCore.Mvc;
using Netflix.WebUı.Services.CommentServices.CommentsServices;

namespace Netflix.WebUı.ViewComponents.SeriesViewComponents
{
    public class _SeriesCommentListViewComponents:ViewComponent
    {
        private readonly ICommentServices _commentServices;

        public _SeriesCommentListViewComponents(ICommentServices commentServices)
        {
            _commentServices = commentServices;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var value=await _commentServices.GetCommentListByContentIdAsync(id);
            return View(value);
        }
    }
}
