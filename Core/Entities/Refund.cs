using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Refund
{
    public int RefundId { get; set; }

    public int? OrderId { get; set; }

    public decimal? Amount { get; set; }

    public string? Reason { get; set; }

    public DateTime? ProcessedAt { get; set; }

    public virtual Order? Order { get; set; }
}
