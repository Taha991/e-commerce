using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Merchant
{
    public int MerchantId { get; set; }

    public string Name { get; set; } = null!;

    public string? SubscriptionStatus { get; set; }

    public int? SubscriptionPackageId { get; set; }

    public DateTime? SubscriptionStartDate { get; set; }

    public DateTime? SubscriptionEndDate { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();

    public virtual SubscriptionPackage? SubscriptionPackage { get; set; }

    public virtual ICollection<Role> Roles { get; } = new List<Role>();
}
