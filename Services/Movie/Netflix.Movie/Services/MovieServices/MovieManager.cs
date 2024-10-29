using Netflix.Movie.Context;
using Netflix.Movie.Dtos.MoviesDtos;
using Netflix.Movie.Entities;
using Microsoft.EntityFrameworkCore;

namespace Netflix.Movie.Services.MovieServices
{
    public class MovieManager : IMovieManager
    {
        private readonly NetflixMovieDbContext _context;

        public MovieManager(NetflixMovieDbContext context)
        {
            _context = context;
        }

        public async Task CreateMovieAsync(CreateMovieDto movieDto)
        {
            var movie = new Movies
            {
                Title = movieDto.Title,
                Description = movieDto.Description,
                ReleaseDate = movieDto.ReleaseDate,
                Duration = movieDto.Duration,
            };

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                throw new KeyNotFoundException($"Film bulunamadı: {id}");
            }
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultMovieDto>> GetAllMovieAsync()
        {
            var movieList = await _context.Movies.ToListAsync();

            var resultList = movieList.Select(s => new ResultMovieDto
            {
                MoviesId = s.MoviesId,
                Title = s.Title,
                ReleaseDate = s.ReleaseDate,
                Duration= s.Duration,
                Description = s.Description,
            }).ToList();

            return resultList;
        }

        public async Task<GetByIdMovieDto> GetMovieByIdAsync(int id)
        {
            var value = await _context.Movies.FindAsync(id);
            if (value == null)
            {
                throw new KeyNotFoundException($"Film bulunamadı: {id}");
            }

            var result = new GetByIdMovieDto
            {
                MoviesId = value.MoviesId,
                Title = value.Title,
                Description = value.Description,
                ReleaseDate = value.ReleaseDate,
                Duration = value.Duration
            };
            return result;
        }

        public async Task UpdateMovieAsync(UpdateMovieDto movieDto)
        {
            var movie = await _context.Movies.FindAsync(movieDto.MoviesId);
            if (movie == null)
            {
                throw new KeyNotFoundException($"Film bulunamadı: {movieDto.MoviesId}");
            }

            movie.Title = movieDto.Title;
            movie.Description = movieDto.Description;
            movie.ReleaseDate = movieDto.ReleaseDate;
            movie.Duration = movieDto.Duration;

            await _context.SaveChangesAsync();
        }
    }
}
