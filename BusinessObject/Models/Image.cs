using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Image
{
    public int Id { get; set; }

    public int? Birdid { get; set; }

    public int? Cageid { get; set; }

    public string? Path { get; set; }

    public virtual Bird? Bird { get; set; }

    public virtual Cage? Cage { get; set; }
}
