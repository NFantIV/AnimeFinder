using System.ComponentModel.DataAnnotations.Schema;

public class Character
{
    public int Id { get; set; }
    public string? CharacterImageURL { get; set; }

    public string? Name { get; set; }

    public string? StrongestAttack { get; set; }

    public string? MainRival { get; set; }

    public int ShowId { get; set; }
    
    [ForeignKey(nameof(ShowId))]
    public virtual Show Show { get; set; } = null!;
}