using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ProductSale
{
    public int SaleId { get; set; }

    public int? ProductId { get; set; }

    public int? SaleCount { get; set; }

    public virtual Product? Product { get; set; }
}
