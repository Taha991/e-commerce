using System;
using System.Collections.Generic;

namespace MemoApi.Data.Models;

public partial class CustomerInteraction
{
    public int InteractionId { get; set; }

    public int? CustomerId { get; set; }

    public string? Note { get; set; }

    public int? InteractedBy { get; set; }

    public DateTime? InteractionDate { get; set; }

    public int? InteractionTypeId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual UserAuth? InteractedByNavigation { get; set; }

    public virtual InteractionType? InteractionType { get; set; }
}
