using System;
using System.Collections.Generic;

namespace AngularCoreAPIApp.Server.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
