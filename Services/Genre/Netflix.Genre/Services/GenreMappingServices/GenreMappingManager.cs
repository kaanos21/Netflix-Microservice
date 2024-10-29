using Microsoft.EntityFrameworkCore;
using Netflix.Genre.Context;
using Netflix.Genre.Dtos.GenreMappingDtos;
using Netflix.Genre.Entitites;

namespace Netflix.GenreMapping.Services.GenreMappingMappingServices
{
    public class GenreMappingMappingManager : IGenreMappingMappingManager
    {
        private readonly NetflixGenreContext _context;

        public GenreMappingMappingManager(NetflixGenreContext context)
        {
            _context = context;
        }

        public async Task CreateGenreMappingAsync(CreateGenreMappingDto genreMappingDto)
        {
            var genreMapping = new GenreMappings
            {
                ContentId = genreMappingDto.ContentId,
                GenresId = genreMappingDto.GenresId,
            };
            _context.GenreMappings.Add(genreMapping);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGenreMappingAsync(int id)
        {
            var genreMapping = await _context.GenreMappings.FindAsync(id);
            if (genreMapping == null)
            {
                throw new KeyNotFoundException($"Genre mapping bulunamadı: {id}");
            }

            _context.GenreMappings.Remove(genreMapping);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultGenreMappingDto>> GetAllGenreMappingAsync()
        {
            return await _context.GenreMappings
                .Select(g => new ResultGenreMappingDto
                {
                    GenreMappingId=g.GenreMappingsId,
                    ContentId = g.ContentId,
                    GenresId = g.GenresId
                })
                .ToListAsync();
        }

        public async Task<GetByIdGenreMappingDto> GetGenreMappingByIdAsync(int id)
        {
            var genreMapping = await _context.GenreMappings.FindAsync(id);
            if (genreMapping == null)
            {
                throw new KeyNotFoundException($"Genre mapping bulunamadı: {id}");
            }

            return new GetByIdGenreMappingDto
            {
                ContentId = genreMapping.ContentId,
                GenresId = genreMapping.GenresId
            };
        }

        public async Task UpdateGenreMappingAsync(UpdateGenreMappingDto genreMappingDto)
        {
            var genreMapping = await _context.GenreMappings.FindAsync(genreMappingDto.GenreMappingId);
            if (genreMapping == null)
            {
                throw new KeyNotFoundException($"Genre mapping bulunamadı: {genreMappingDto.GenreMappingId}");
            }

            genreMapping.ContentId = genreMappingDto.ContentId;
            genreMapping.GenresId = genreMappingDto.GenresId;
            await _context.SaveChangesAsync();
        }
    }
}
