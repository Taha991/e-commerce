using System;
using System.Collections.Generic;

namespace MemoApi.Data.Models;

public partial class ProductSale
{
    public int SaleId { get; set; }

    public int? ProductId { get; set; }

    public int? SaleCount { get; set; }

    public virtual Product? Product { get; set; }
}
