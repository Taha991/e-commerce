using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Merchant> Merchants { get; } = new List<Merchant>();

    public virtual ICollection<UserAuth> Users { get; } = new List<UserAuth>();
}
