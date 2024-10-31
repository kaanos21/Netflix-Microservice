using Microsoft.AspNetCore.Mvc;
using Netflix.DtoLayer.ContentDtos.SeriesDto;
using Netflix.WebUı.Services.ContentServices.SeasonService;
using Netflix.WebUı.Services.ContentServices.SeriesServices;

namespace Netflix.WebUı.Controllers
{
    public class SeriesController : Controller
    {
        private readonly ISeriesService _seriesService;
        private readonly ISeasonService _seasonService;

        public SeriesController(ISeriesService seriesService, ISeasonService seasonService)
        {
            _seriesService = seriesService;
            _seasonService = seasonService;
        }

        public async Task<IActionResult> SeriesList()
        {
            var value= await _seriesService.GetAllSeriesAsync();
            return View(value);
        }
        public async Task<IActionResult> DeleteSeries(int id)
        {
            await _seriesService.DeleteSeriesAsync(id);
            return RedirectToAction("SeriesList", "Series");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateSeries(int id)
        {
            var value= await _seriesService.GetSeriesByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSeries(UpdateSeriesDto updateSeriesDto)
        {
            await _seriesService.UpdateSeriesAsync(updateSeriesDto);
            return RedirectToAction("SeriesList");
        }
        [HttpGet]
        public async Task<IActionResult> CreateSeries()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSeries(CreateSeriesDto createSeriesDto)
        {
            await _seriesService.CreateSeriesAsync(createSeriesDto);
            return RedirectToAction("SeriesList");
        }
        public async Task<IActionResult> GetSeasonSeries(int id)
        {
            var value=await _seasonService.GetListSeasonWithSeriesNameBySeriesId(id);
            return View(value);
        }
    }
}
