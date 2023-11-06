using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Bird
{
    public int Id { get; set; }

    public int Cageid { get; set; }

    public string? Name { get; set; }

    public string? AgePeriod { get; set; }

    public bool? IsPregnant { get; set; }

    public bool? IsFeathering { get; set; }

    public int? IsDisable { get; set; }

    public virtual ICollection<BirdFood> BirdFoods { get; set; } = new List<BirdFood>();

    public virtual Cage Cage { get; set; } = null!;

    public virtual ICollection<History> Histories { get; set; } = new List<History>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
