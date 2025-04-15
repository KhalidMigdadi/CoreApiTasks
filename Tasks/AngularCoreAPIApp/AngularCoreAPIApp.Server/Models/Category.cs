using System;
using System.Collections.Generic;

namespace AngularCoreAPIApp.Server.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
