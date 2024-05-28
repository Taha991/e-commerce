using System;
using System.Collections.Generic;

namespace MemoApi.Data.Models;

public partial class ProductVariant
{
    public int VariantId { get; set; }

    public int? ProductId { get; set; }

    public string? Sku { get; set; }

    public decimal? Price { get; set; }

    public int? Stock { get; set; }

    public string? State { get; set; }

    public string? Attributes { get; set; }

    public virtual ICollection<Inventory> Inventories { get; } = new List<Inventory>();

    public virtual Product? Product { get; set; }
}
