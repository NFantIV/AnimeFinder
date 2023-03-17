using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class ShowDetail
    {
    public int Id { get; set; }
    public string? Name { get; set; }
    public Genre Genre { get; set; }

    public WhereToWatch WhereToWatch { get; set; }

    public List<SeasonListItem> Seasons { get; set; } = new List<SeasonListItem>();
    public List<CharacterListItem> Characters { get; set; } = new List<CharacterListItem>();
    }
