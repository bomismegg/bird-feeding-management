using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class History
{
    public int Birdid { get; set; }

    public int Foodid { get; set; }

    public long Timestamp { get; set; }

    public float? Quantity { get; set; }

    public virtual Bird Bird { get; set; } = null!;

    public virtual Food Food { get; set; } = null!;
}
