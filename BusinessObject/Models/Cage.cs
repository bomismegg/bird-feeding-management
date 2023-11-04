using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Cage
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? IsAutomatic { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Bird> Birds { get; set; } = new List<Bird>();

    public virtual ICollection<CageFood> CageFoods { get; set; } = new List<CageFood>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<Plan> Plans { get; set; } = new List<Plan>();
}
