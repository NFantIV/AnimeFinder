using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Show
{
    public int Id { get; set; }
    public string? ShowImageURL { get; set; }

    public string? Name { get; set; }

    public Genre Genre {get; set; }

    public WhereToWatch WhereToWatch { get; set; }

    public List<Season> Seasons { get; set; } = new List<Season>();
    
    public List<Character> Characters { get; set; } = new List<Character>();
}
