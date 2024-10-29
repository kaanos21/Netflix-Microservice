using Microsoft.EntityFrameworkCore;
using Netflix.Genre.Context;
using Netflix.Genre.Dtos.GenresDtos;
using Netflix.Genre.Entitites;

namespace Netflix.Genre.Services.GenresServices
{
    public class GenresManager : IGenresManager
    {
        private readonly NetflixGenreContext _context;

        public GenresManager(NetflixGenreContext context)
        {
            _context = context;
        }

        public async Task CreateGenreAsync(CreateGenresDto genresDto)
        {
            var genre = new Genres
            {
                Name = genresDto.Name
            };

            _context.Genres.Add(genre);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGenreAsync(int id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre == null)
            {
                throw new KeyNotFoundException($"Genre bulunamadı: {id}");
            }
            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultGenresDto>> GetAllGenreAsync()
        {
            var genreList = await _context.Genres.ToListAsync();

            var resultList = genreList.Select(s => new ResultGenresDto
            {
                GenresId = s.GenresId,
                Name = s.Name
            }).ToList();

            return resultList;
        }

        public async Task<GetByIdGenresDto> GetGenreByIdAsync(int id)
        {
            var value = await _context.Genres.FindAsync(id);
            if (value == null)
            {
                throw new KeyNotFoundException($"Genre bulunamadı: {id}");
            }

            var result = new GetByIdGenresDto
            {
                GenresId = value.GenresId,
                Name = value.Name
            };
            return result;
        }

        public async Task UpdateGenreAsync(UpdateGenresDto genresDto)
        {
            var genre = await _context.Genres.FindAsync(genresDto.GenresId);
            if (genre == null)
            {
                throw new KeyNotFoundException($"Genre bulunamadı: {genresDto.GenresId}");
            }

            genre.Name = genresDto.Name;

            await _context.SaveChangesAsync();
        }
    }
}
