using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Plan
{
    public int Id { get; set; }

    public int Cageid { get; set; }

    public string? Name { get; set; }

    public bool? IsAutomatic { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Description { get; set; }

    public virtual Cage Cage { get; set; } = null!;

    public virtual ICollection<PlanFood> PlanFoods { get; set; } = new List<PlanFood>();
}
