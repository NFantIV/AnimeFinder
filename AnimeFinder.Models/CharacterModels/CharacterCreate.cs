using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

public class CharacterCreate
    {
    public int Id { get; set; }
    public string? CharacterImageURL { get; set; }

    public string? Name { get; set; }

    public string? StrongestAttack { get; set; }

    public string? MainRival { get; set; }
    public int ShowId { get; set; }
    [ValidateNever]
    public IEnumerable<SelectListItem>? ShowSelection { get; set; }

}
