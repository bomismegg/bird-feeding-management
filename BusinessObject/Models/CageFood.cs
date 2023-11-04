using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class CageFood
{
    public int Cageid { get; set; }

    public int Foodid { get; set; }

    public float? Remaining { get; set; }

    public float? Capacity { get; set; }

    public virtual Cage Cage { get; set; } = null!;

    public virtual Food Food { get; set; } = null!;
}
