using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    public string Location { get; set; } = null!;

    public int? Capacity { get; set; }
}
