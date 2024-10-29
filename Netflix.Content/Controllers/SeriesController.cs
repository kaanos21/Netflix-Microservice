using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netflix.Content.Dtos.SeriesDto;
using Netflix.Content.Services.SeriesServices;

namespace Netflix.Content.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private readonly ISeriesManager _seriesManager;

        public SeriesController(ISeriesManager seriesManager)
        {
            _seriesManager = seriesManager;
        }
        [HttpPost]
        public async Task<IActionResult> CreateSeries(CreateSeriesDto createSeriesDto)
        {
            await _seriesManager.CreateSeriesAsync(createSeriesDto);
            return Ok("başarı ile eklendi");
        }
        [HttpGet]
        public async Task<IActionResult> GetListSeries()
        {
            var value =await _seriesManager.GetAllSeriesAsync();
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSeries(UpdateSeriesDto updateSeriesDto)
        {
            await _seriesManager.UpdateSeriesAsync(updateSeriesDto);
            return Ok("başarı ile güncellendi");
        }
        [HttpGet("GetByIdSeries")]
        public async Task<IActionResult> GetByIdSeries(int id)
        {
            var value = await _seriesManager.GetSeriesByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteSeries(int id)
        {
            await _seriesManager.DeleteSeriesAsync(id);
            return Ok("Silindi");
        }
    }
}
