using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class PlanFood
{
    public int Planid { get; set; }

    public int Foodid { get; set; }

    public float? Quantity { get; set; }

    public virtual Food Food { get; set; } = null!;

    public virtual Plan Plan { get; set; } = null!;
}
