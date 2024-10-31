using Microsoft.AspNetCore.Mvc;
using Netflix.WebUı.Services.ContentServices.SeasonService;

namespace Netflix.WebUı.Controllers
{
    public class SeasonController : Controller
    {
        private readonly ISeasonService _seasonService;

        public SeasonController(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }
        [HttpGet]
        public async Task<IActionResult> SeriesSeasonList(int id)
        {
            var value = await _seasonService.GetListSeasonWithSeriesNameBySeriesId(id);
            return View(value);
        }
    }
}
