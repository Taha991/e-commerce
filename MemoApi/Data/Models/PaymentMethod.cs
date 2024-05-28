using System;
using System.Collections.Generic;

namespace MemoApi.Data.Models;

public partial class PaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
