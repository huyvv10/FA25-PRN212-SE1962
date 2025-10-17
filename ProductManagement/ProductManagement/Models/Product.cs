using System;
using System.Collections.Generic;

namespace ProductManagement.Models;

public partial class Product
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public int Qty { get; set; }

    public string CatId { get; set; } = null!;

    public virtual Category Cat { get; set; } = null!;
}
