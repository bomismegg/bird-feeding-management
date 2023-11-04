using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Password { get; set; }

    public bool? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public bool? Status { get; set; }

    public int? Role { get; set; }
}
