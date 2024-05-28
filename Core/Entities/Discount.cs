using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Discount
{
    public int DiscountId { get; set; }

    public int? ProductId { get; set; }

    public string? Description { get; set; }

    public string? DiscountType { get; set; }

    public decimal? DiscountValue { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Active { get; set; }

    public string? RequiredSubscriptionLevel { get; set; }

    public virtual Product? Product { get; set; }
}
