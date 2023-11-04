using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Food
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<BirdFood> BirdFoods { get; set; } = new List<BirdFood>();

    public virtual ICollection<CageFood> CageFoods { get; set; } = new List<CageFood>();

    public virtual ICollection<PlanFood> PlanFoods { get; set; } = new List<PlanFood>();
}
