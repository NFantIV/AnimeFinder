using System.ComponentModel.DataAnnotations.Schema;

public class Season
{
    public int Id { get; set; }

    public int NumberOfSeasons { get; set; }

    public int EpisodeCount { get; set; }

    public int ShowId { get; set; }
    
    [ForeignKey(nameof(ShowId))]
    public virtual Show Show { get; set; } = null!;

}