using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


    public class SeasonDetail
    {
        public int Id { get; set; }
        public int NumberOfSeasons { get; set; }
        public int EpisodeCount { get; set; }

        public ShowListItem Show { get; set; } = null!;
    }
