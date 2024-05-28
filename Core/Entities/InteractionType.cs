using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class InteractionType
{
    public int InteractionTypeId { get; set; }

    public string InteractionTypeName { get; set; } = null!;

    public virtual ICollection<CustomerInteraction> CustomerInteractions { get; } = new List<CustomerInteraction>();
}
