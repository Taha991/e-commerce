using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public int? MerchantId { get; set; }

    public int? PaymentMethodId { get; set; }

    public DateTime? Date { get; set; }

    public decimal Total { get; set; }

    public string? Status { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Merchant? Merchant { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual PaymentMethod? PaymentMethod { get; set; }

    public virtual ICollection<Refund> Refunds { get; } = new List<Refund>();
}
