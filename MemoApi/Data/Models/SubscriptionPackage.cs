using System;
using System.Collections.Generic;

namespace MemoApi.Data.Models;

public partial class SubscriptionPackage
{
    public int SubscriptionPackageId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string Duration { get; set; } = null!;

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<Merchant> Merchants { get; } = new List<Merchant>();
}
