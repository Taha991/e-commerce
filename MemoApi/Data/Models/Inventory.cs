using System;
using System.Collections.Generic;

namespace MemoApi.Data.Models;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public int? VariantId { get; set; }

    public int? Quantity { get; set; }

    public int? WarehouseId { get; set; }

    public virtual ProductVariant? Variant { get; set; }
}
