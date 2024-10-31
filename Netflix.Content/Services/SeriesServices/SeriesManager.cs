using Microsoft.EntityFrameworkCore;
using Netflix.Content.Context;
using Netflix.Content.Dtos.SeriesDto;
using Netflix.Content.Entities;

namespace Netflix.Content.Services.SeriesServices
{
    public class SeriesManager : ISeriesManager
    {
        private readonly NetflixContentContext _context;

        public SeriesManager(NetflixContentContext context)
        {
            _context = context;
        }
        public async Task CreateSeriesAsync(CreateSeriesDto seriesDto)
        {
            var series = new Series
            {
                Title = seriesDto.Title,
                Description = seriesDto.Description,
                ReleaseDate = DateTime.Now.ToUniversalTime(),
                TotalSeasons = seriesDto.TotalSeasons
            };

            _context.Series.Add(series); 
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSeriesAsync(int id)
        {
            var series = await _context.Series.FindAsync(id);
            _context.Series.Remove(series);
            await _context.SaveChangesAsync();
        }
        public async Task<List<ResultSeriesDto>> GetAllSeriesAsync()
        {
            var seriesList = await _context.Series.ToListAsync();

            
            var resultList = seriesList.Select(s => new ResultSeriesDto
            {
                SeriesId = s.SeriesId, 
                Title = s.Title,       
                Description = s.Description, 
                ReleaseDate = s.ReleaseDate, 
                TotalSeasons = s.TotalSeasons  
            }).ToList();

            return resultList;
        }
        public async Task<UpdateSeriesDto> GetSeriesByIdAsync(int id)
        {
            var value = await _context.Series.FindAsync(id);
            var result = new UpdateSeriesDto
            {
                SeriesId = value.SeriesId, 
                Title = value.Title,       
                Description = value.Description, 
                ReleaseDate = value.ReleaseDate, 
                TotalSeasons = value.TotalSeasons
            };
            return result;
        }

        public async Task<GetByIdSeriesDto> GetSeriesDetailByIdAsync(int id)
        {
            var value = await _context.Series.FindAsync(id);
            var result = new GetByIdSeriesDto
            {
                SeriesId = value.SeriesId,
                Title = value.Title,
                Description = value.Description,
                ReleaseDate = value.ReleaseDate,
                TotalSeasons = value.TotalSeasons
            };
            return result;
        }

        public async Task UpdateSeriesAsync(UpdateSeriesDto seriesDto)
        {
            try
            {
                //{29.10.2024 18:49:29}
                var series = await _context.Series.FindAsync(seriesDto.SeriesId);
                if (series == null)
                {
                    throw new KeyNotFoundException($"Seri bulunamadı: {seriesDto.SeriesId}");
                }
                series.Title = seriesDto.Title;
                series.Description = seriesDto.Description;
                series.ReleaseDate = seriesDto.ReleaseDate.ToUniversalTime();
                series.TotalSeasons = seriesDto.TotalSeasons;

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Hata mesajını logla
                Console.WriteLine($"Hata: {ex.Message}");
                throw; // Hatanın dışarı fırlatılmasını sağla
            }
        }

    }
}