using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ShowEdit
{   [Required]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }

    public Genre Genre { get; set; }

    public WhereToWatch WhereToWatch { get; set; }
    [ValidateNever]
    public IEnumerable<SelectListItem>? WhereToWatchSelection { get; set; }

    [ValidateNever]
    public IEnumerable<SelectListItem>? GenresSelection { get; set; }
}
