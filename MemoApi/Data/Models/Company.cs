using System;
using System.Collections.Generic;

namespace MemoApi.Data.Models;

public partial class Company
{
    public int BrandId { get; set; }

    public string Username { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? AdditionalInfo { get; set; }

    public int? SubscriptionPackageId { get; set; }

    public DateTime? SubscriptionStartDate { get; set; }

    public DateTime? SubscriptionEndDate { get; set; }

    public virtual SubscriptionPackage? SubscriptionPackage { get; set; }
}
