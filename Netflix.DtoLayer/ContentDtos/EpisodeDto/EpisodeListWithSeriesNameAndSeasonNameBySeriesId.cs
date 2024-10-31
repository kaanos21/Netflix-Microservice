using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.DtoLayer.ContentDtos.EpisodeDto
{
    public class EpisodeListWithSeriesNameAndSeasonNameBySeriesId
    {
        public int EpisodeId { get; set; }
        public int SeasonId { get; set; }
        public string SeasonName { get; set; }
        public int EpisodeNumber { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string StreamFileUrl { get; set; }
        public string SeriesName { get; set; }
        public int SeasonNumber { get; set; }


    }
}
