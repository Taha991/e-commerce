using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ProductView
{
    public int ViewId { get; set; }

    public int? ProductId { get; set; }

    public int? ViewCount { get; set; }

    public virtual Product? Product { get; set; }
}
