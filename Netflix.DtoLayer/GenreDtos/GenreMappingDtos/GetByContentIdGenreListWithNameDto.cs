using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.DtoLayer.GenreDtos.GenreMappingDtos
{
    public class GetByContentIdGenreListWithNameDto
    {
        public int GenreMappingId { get; set; }
        public int ContentId { get; set; }
        public int GenresId { get; set; }
        public string GenreName { get; set; }
    }
}
